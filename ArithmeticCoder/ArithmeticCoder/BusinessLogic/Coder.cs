using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoder
{
    class Coder
    {
        private BitWriter Writer;
        private Model arithmeticModel;

        private UInt64 Range;
        private UInt32 UnderflowBits = 0;
        private UInt32 High = 0xFFFFFFFF;
        private UInt32 Low  = 0x00000000;

        private readonly UInt32 firstShiftingMask  =  0x80000000;
        private readonly UInt32 secondShigtingMask =  0x40000000;
        private readonly UInt32 first2BitsMask     =  0x3FFFFFFF;

        private const int EOF = 256, TOTAL_SYMBOLS = 257, NR_BITS_TO_READ = 8;

        public Coder(BitWriter writer)
        {
            Writer = writer;
            arithmeticModel = new Model(TOTAL_SYMBOLS);
        }

        private void EncodeSymbol(uint symbol)
        {
            Range = (ulong)High - Low + 1;
            High = Low + (uint)((Range * arithmeticModel.GetSymbolSumLimitH(symbol)) / arithmeticModel.GetSymbolTotalSum() - 1);
            Low  = Low + (uint)((Range * arithmeticModel.GetSymbolSumLimitL(symbol)) / arithmeticModel.GetSymbolTotalSum());

            for (; ; )
            {
                // Test First shift MSB(H) = MSB(L) = 0 or MSB(H) = MSB(L) = 1
                if ((High & firstShiftingMask) == (Low & firstShiftingMask))
                {
                    // Send the stabilized bit and the shiftings
                    uint msbFromHigh = (High >> 31);                 //uint
                    WriteBitAndUnderflowBits(msbFromHigh);

                    // Set the last bit from High and Low
                    High <<= 1;
                    High |= 1;
                    Low <<= 1;
                }
                // Test Second shift (first 2 semnificative bits of H = 10; L = 01;)
                else if ((Low & secondShigtingMask) != 0 && (High & secondShigtingMask) == 0)
                {
                    UnderflowBits++;
                    High |= secondShigtingMask;
                    Low &= first2BitsMask;

                    // Set the last bit from High and Low
                    High <<= 1;
                    High |= 1;
                    Low <<= 1;
                }
                else
                    return;
            }

        }

        private void FlushEncoder()
        {
            // Get the second bit from Low
            uint msbFromLow = ((Low << 1) >> 31); //uint
            UnderflowBits++;
            WriteBitAndUnderflowBits(msbFromLow);
        }

        private void WriteBitAndUnderflowBits(uint bit) //uint bit
        {
            Writer.WriteNBits(bit, 1);
            while (UnderflowBits > 0)
            {
                Writer.WriteNBits(~bit, 1);
                UnderflowBits--;
            }
        }

        public static void CompressFile(string inputFile, string outputFile)
        {
            // Read uncompressed file variables
            BitReader reader = new BitReader(inputFile);
            var inputSize = NR_BITS_TO_READ * new FileInfo(inputFile).Length;

            // Write compressed file variables
            BitWriter writer = new BitWriter(outputFile);
            Coder coder = new Coder(writer);

            for (var i = inputSize - 1; i >= 0; i -= 8) 
            {
                uint symbol = Convert.ToUInt32(reader.ReadNBits(NR_BITS_TO_READ));

                // For each symbol and update the model statistics
                coder.EncodeSymbol(symbol);
                coder.arithmeticModel.UpdateModel(symbol);

            }

            reader.Dispose();

            coder.EncodeSymbol(EOF);
            coder.FlushEncoder();
            writer.WriteNBits(1, 7);
            writer.Dispose();

        }
        
    }
}
