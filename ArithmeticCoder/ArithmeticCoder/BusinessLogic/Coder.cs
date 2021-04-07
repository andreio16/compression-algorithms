﻿using System;
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

        private readonly UInt32 FirstShiftingMask = 0x80000000;
        private readonly UInt32 SecondShigtingMask_1 = 0x40000000;
        private readonly UInt32 SecondShigtingMask_2 = 0x3FFFFFFF;

        public Coder(BitWriter writer)
        {
            Writer = writer;
        }

        private void EncodeSymbol(int symbol, Model arihmeticModel)
        {
            Range = (ulong)High - Low + 1;
            High = Low + (uint)((Range * arihmeticModel.GetSymbolSumLimitH(symbol)) / arihmeticModel.GetSymbolTotalSum() - 1);
            Low = Low + (uint)((Range * arihmeticModel.GetSymbolSumLimitL(symbol)) / arihmeticModel.GetSymbolTotalSum());

            for (; ; )
            {
                // Test First shift MSB(H) = MSB(L) = 0 or MSB(H) = MSB(L) = 1
                if ((High & FirstShiftingMask) == (Low & FirstShiftingMask))
                {
                    // Send the stabilized bit and the shiftings
                    uint msbFromHigh = (High >> 31);
                    WriteBitAndUnderflowBits(msbFromHigh);
                }
                // Test Second shift (first 2 semnificative bits of H = 10; L = 01;)
                else if ((Low & SecondShigtingMask_1) != 0 && (High & FirstShiftingMask) != 0)
                {
                    UnderflowBits++;
                    High |= SecondShigtingMask_1;
                    Low &= SecondShigtingMask_2;
                }
                else
                    return;
                High <<= 1;
                High |= 1;
                Low <<= 1;
            }

        }

        private void FlushEncoder()
        {
            // Trimitem decodorului bitii din low direct sau prin WriteBitAndUnderflowBits (?)
            uint msbFromLow = ((Low << 1) >> 31);
            Writer.WriteNBits(msbFromLow, 1);
            Writer.WriteNBits(~msbFromLow, 1);
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
            Coder arithmeticCoder = new Coder(writer);
            Model arithmeticModel = new Model(257);

            for (var i = inputSize - 1; i >= 0; i--)
            {
                byte symbol = Convert.ToByte(reader.ReadNBits(8));

                // For each symbol and update the model statistics
                arithmeticModel.UpdateModel(Convert.ToInt32(symbol));

            }
            //arithmeticCoder.EncodeSymbol( (?), arithmeticModel);
            arithmeticCoder.EncodeSymbol(256, arithmeticModel);
            arithmeticCoder.FlushEncoder();
            writer.WriteNBits(1, 7);    // (?)
            writer.Dispose();
            reader.Dispose();

        }
        
    }
}
