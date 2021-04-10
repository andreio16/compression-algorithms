using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoder
{
    class BitReader : IDisposable
    {
        private FileStream inputFile;
        private int readBitsCounter = 0;
        private int readBuffer = 0;

        public BitReader(string filePath)
        {
            inputFile = new FileStream(filePath, FileMode.Open);
        }

        private uint ReadBit()
        {
            if (readBitsCounter == 0)
            {
                readBuffer = Convert.ToByte(inputFile.ReadByte());
                readBitsCounter = 8;
            }
            readBitsCounter--;
            uint bit = (uint)(readBuffer % 2);
            readBuffer >>= 1;
            return bit;
        }

        public uint ReadNBits(int numOfBits)
        {
            uint value = 0;

            for (int i = 0; i < numOfBits; i++)
                value |= (ReadBit() << i);

            return value;
        }

        public void Dispose()
        {
            inputFile.Dispose();
        }
    }
}
