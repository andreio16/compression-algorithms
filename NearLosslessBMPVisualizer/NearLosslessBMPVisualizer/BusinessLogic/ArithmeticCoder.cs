using System;

namespace NearLosslessBMPVisualizer
{
    class ArithmeticCoder
    {
        private BitWriter Writer;
        private ArithmeticModel arithmeticModel;

        private UInt64 Range;
        private UInt32 UnderflowBits = 0;
        private UInt32 High = 0xFFFFFFFF;
        private UInt32 Low  = 0x00000000;

        private readonly UInt32 firstShiftingMask  =  0x80000000;
        private readonly UInt32 secondShigtingMask =  0xC0000000;

        private const int EOF = 512, TOTAL_SYMBOLS = 513;

        public ArithmeticCoder(BitWriter writer)
        {
            Writer = writer;
            arithmeticModel = new ArithmeticModel(TOTAL_SYMBOLS);
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
                    uint msbFromHigh = (High >> 31);
                    WriteBitAndUnderflowBits(msbFromHigh);

                    // Set the last bit from High and Low
                    High <<= 1;
                    High |= 1;
                    Low <<= 1;
                }
                // Test Second shift (first 2 semnificative bits of H = 10; L = 01;)
                else if ((Low & secondShigtingMask) == 0x40000000 && (High & secondShigtingMask) == 0x80000000) 
                {
                    UnderflowBits++;
                    High |= 0x40000000;
                    Low  &= 0x3FFFFFFF;

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
            uint msbFromLow = Low >> 30;

            // Send 2 bits to compressed file : second msb and ~msb 
            UnderflowBits++;
            WriteBitAndUnderflowBits(msbFromLow);
        }

        private void WriteBitAndUnderflowBits(uint value) 
        {
            value &= 0x00000001;
            Writer.WriteNBits(value, 1);

            uint negatedValue = (~value & 0x00000001);
            while (UnderflowBits > 0)
            {
                Writer.WriteNBits(negatedValue, 1); 
                UnderflowBits--;
            }
        }

        public static void CompressData(int[,] dataMatrix, BitWriter writer)
        {
            // Write compressed file variables
            ArithmeticCoder coder = new ArithmeticCoder(writer);
            var size = (int)Math.Sqrt(dataMatrix.Length);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    uint symbol = Convert.ToUInt32(dataMatrix[i, j] + 255);

                    // For each symbol and update the model statistics
                    coder.EncodeSymbol(symbol);
                    coder.arithmeticModel.UpdateModel(symbol);
                }
            }
            coder.EncodeSymbol(EOF);
            coder.FlushEncoder();
            writer.WriteNBits(1, 7);
            writer.Dispose();
        }
    }
}
