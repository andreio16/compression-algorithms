using System;
using System.Collections.Generic;

namespace NearLosslessBMPVisualizer
{
    class ArithmeticDecoder
    {
        private BitReader reader;
        private ArithmeticModel arithmeticModel;

        private UInt64 Range;
        private UInt32 Code = 0;
        private UInt32 High = 0xFFFFFFFF;
        private UInt32 Low  = 0x00000000;


        private readonly UInt32 firstShiftingMask   = 0x80000000;
        private readonly UInt32 secondShiftingMask  = 0xC0000000;

        private const int EOF = 512, TOTAL_SYMBOLS = 513;

        public ArithmeticDecoder(BitReader reader)
        {
            this.reader = reader;
            Code = reader.ReadNBits(32);
            arithmeticModel = new ArithmeticModel(TOTAL_SYMBOLS);
        }

        private uint DecodeSymbol()
        {
            Range = (ulong)(High - Low) + 1;

            uint code_sum = (uint)(((ulong)(Code - Low + 1) * arithmeticModel.GetSymbolTotalSum() - 1) / Range); 
            uint symbol = arithmeticModel.GetSymbolForSpecifiedSum(code_sum);

            High = Low + (uint)((Range * arithmeticModel.GetSymbolSumLimitH(symbol)) / arithmeticModel.GetSymbolTotalSum() - 1);
            Low  = Low + (uint)((Range * arithmeticModel.GetSymbolSumLimitL(symbol)) / arithmeticModel.GetSymbolTotalSum());
            

            for (; ; )
            {
                if ((High & firstShiftingMask) == (Low & firstShiftingMask))
                {
                    Low <<= 1;
                    High <<= 1;
                    High |= 1;
                    Code = (Code << 1) | reader.ReadNBits(1);
                }
                else if ((Low & secondShiftingMask) == 0x40000000 && (High & secondShiftingMask) == 0x80000000) 
                {
                    Code = ((Code ^ 0x40000000) << 1) | reader.ReadNBits(1);
                    High = ((High | 0x40000000) << 1) | 1;
                    Low  = (Low & 0x3FFFFFFF) << 1;
                }
                else
                    break;
            }
            return symbol;

        }

        public static List<uint> DecompressData(BitReader reader)
        {
            ArithmeticDecoder  decoder = new ArithmeticDecoder(reader);
            var decompressedData = new List<uint>();

            // reading loop...
            for (; ; )
            {
                uint symbol = decoder.DecodeSymbol();
                if (symbol == EOF) break;
                decompressedData.Add(symbol);
                decoder.arithmeticModel.UpdateModel(symbol);
            }
            return decompressedData;
        }
    }
}
