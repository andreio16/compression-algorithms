using System;
using System.IO;

namespace NearLosslessBMPVisualizer
{
    public class BitReader : IDisposable
    {
        private FileStream inputFile;
        private int readBitsCounter = 0;
        private byte readBuffer = 0;

        public BitReader(string filePath)
        {
            inputFile = new FileStream(filePath, FileMode.Open);
        }

        private int ReadBit()
        {
            // Check if buffer is empty
            if (readBitsCounter == 0)
            {
                readBuffer = (byte)inputFile.ReadByte();
                readBitsCounter = 8;
            }

            // Take first bit
            int bit = 0;
            int mask = 1 << (readBitsCounter - 1);
            bit = (readBuffer & mask) >> (readBitsCounter - 1);

            readBitsCounter--;
            return bit;
        }

        public uint ReadNBits(int numOfBits)
        {
            uint result = 0;

            for (int i = numOfBits - 1; i >= 0; i--)
            {
                byte bit = (byte)ReadBit();
                result = (result << 1) + bit;
            }

            return result;
        }

        public void Dispose()
        {
            inputFile.Dispose();
        }
    }
}