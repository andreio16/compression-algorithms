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

        public Coder(BitWriter writer)
        {
            Writer = writer;
            arithmeticModel = new Model(257);
        }

        private void EncodeSymbol(int symbol)
        {
            Range = (ulong)High - Low + 1;
            High = Low + (uint)((Range * arithmeticModel.GetSymbolSumLimitH(symbol)) / arithmeticModel.GetSymbolTotalSum() - 1);
            Low = Low + (uint)((Range * arithmeticModel.GetSymbolSumLimitL(symbol)) / arithmeticModel.GetSymbolTotalSum());

            for (; ; )
            {
                // Test First shift MSB(H) = MSB(L) = 0 or MSB(H) = MSB(L) = 1
                if ((High & firstShiftingMask) == (Low & firstShiftingMask))
                {
                    // Send the stabilized bit and the shiftings
                    uint msbFromHigh = (High >> 31);
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
            uint msbFromLow = ((Low << 1) >> 31);
            UnderflowBits++;
            WriteBitAndUnderflowBits(msbFromLow);
        }

        private void WriteBitAndUnderflowBits(uint bit)
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
            var inputSize = new FileInfo(inputFile).Length;

            // Write compressed file variables
            BitWriter writer = new BitWriter(outputFile);
            Coder coder = new Coder(writer);

            for (var i = inputSize - 1; i >= 0; i--)
            {
                var symbol = Convert.ToInt32(reader.ReadNBits(8));

                // For each symbol and update the model statistics
                coder.EncodeSymbol(symbol);
                coder.arithmeticModel.UpdateModel(symbol);

            }
            coder.EncodeSymbol(256);
            coder.FlushEncoder();   
            writer.Dispose();
            reader.Dispose();

        }
        
    }
}
