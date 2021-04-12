using System;
using System.IO;

namespace ArithmeticCoder
{
    class Decoder
    {
        private BitReader reader;
        private Model arithmeticModel;

        private UInt64 Range;
        private UInt32 Code = 0;
        private UInt32 High = 0xFFFFFFFF;
        private UInt32 Low  = 0x00000000;


        private readonly UInt32 firstBitMask   = 0x80000000;
        private readonly UInt32 secondBitMask  = 0x40000000;
        private readonly UInt32 first2BitsMask = 0x3FFFFFFF;
        
        private const int EOF = 256, TOTAL_SYMBOLS = 257, NR_BITS_TO_READ = 8;

        public Decoder(BitReader reader)
        {
            this.reader = reader;
            Code = reader.ReadNBits(32);
            arithmeticModel = new Model(TOTAL_SYMBOLS);
        }

        private uint DecodeSymbol()
        {
            Range = (ulong)(High - Low) + 1;

            uint code_sum = (uint)(((ulong)(Code - Low + 1) * arithmeticModel.GetSymbolTotalSum() - 1) / Range); 
            uint symbol = arithmeticModel.GetSymbolForSpecifiedSum(code_sum, EOF);

            High = Low + (uint)((Range * arithmeticModel.GetSymbolSumLimitH(symbol)) / arithmeticModel.GetSymbolTotalSum() - 1);
            Low  = Low + (uint)((Range * arithmeticModel.GetSymbolSumLimitL(symbol)) / arithmeticModel.GetSymbolTotalSum());

            for (; ; )
            {
                if ((High & firstBitMask) == (Low & firstBitMask))
                {
                    Low  <<= 1;      
                    High <<= 1;
                    High |= 1;
                    Code = (Code << 1) | reader.ReadNBits(1);
                }
                else if ((Low & secondBitMask) == secondBitMask && (High & secondBitMask) == 0)
                {
                    Code = ((Code ^ secondBitMask) << 1) | reader.ReadNBits(1);
                    Low  = (Low & first2BitsMask) << 1;
                    High = ((High | firstBitMask) << 1) | 1;
                }
                else
                    break;
            }
            return symbol;

        }

        public static void DecompressFile(string inputFile, string outputFile)
        {
            BitReader reader = new BitReader(inputFile);
            BitWriter writer = new BitWriter(outputFile);
            Decoder  decoder = new Decoder(reader);

            var inputSize = NR_BITS_TO_READ * new FileInfo(inputFile).Length;

            // reading loop...
            while (true)
            {
                uint symbol = decoder.DecodeSymbol();
                if (symbol == EOF) break;
                writer.WriteNBits(symbol, 8);
                decoder.arithmeticModel.UpdateModel(symbol);
                
            }

            reader.Dispose();
            writer.WriteNBits(1, 7);
            writer.Dispose();
        }
    }
}
