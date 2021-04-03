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
        private UInt64 Range;
        private BitWriter Writer;

        private UInt32 High = 0xFFFFFFFF;
        private UInt32 Low = 0x00000000;
        private UInt32 UnderflowBits = 0;

        private readonly UInt32 FirstShiftingMask_1 = 0x80000000;
        private readonly UInt32 FirstShiftingMask_2 = 0x0FFFFFFF;

        private readonly UInt32 SecondShiftingMask = 0xC0000000;
        private readonly UInt32 SecondShigtingHigh = 0x80000000;
        private readonly UInt32 SecondShigtingLow = 0x40000000;

        public Coder(BitWriter writer)
        {
            Writer = writer;
        }

        private void EncodeSymbol(int symbol, Model arihmeticModel)
        {
            Range = (ulong)High - Low + 1;
            High = Low + (uint)(Range * arihmeticModel.GetSymbolSumLimitH(symbol) / arihmeticModel.GetSymbolSumTot() - 1);
            Low = Low + (uint)(Range * arihmeticModel.GetSymbolSum(symbol) / arihmeticModel.GetSymbolSumTot());

        }

        public static void CompressFile(string inputFile, string outputFile)
        {
            BitReader reader = new BitReader(inputFile);
            var inputSize = new FileInfo(inputFile).Length;

            for (var i = inputSize - 1; i >= 0; i--)
            {
                byte symbol = Convert.ToByte(reader.ReadNBits(8));
                
                // Encode each symbol and update the model

            }

        }
        
    }
}
