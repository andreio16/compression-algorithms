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
        private int readBitsCounter = 8;
        private byte readBuffer = 0;

        public BitReader(string filePath)
        {
            inputFile = new FileStream(filePath, FileMode.Open);
        }

        private UInt32 ReadBit()
        {
            if (readBitsCounter % 8 == 0)
            {
                readBuffer = Convert.ToByte(inputFile.ReadByte());
                readBitsCounter = 1;
            }
            else
                readBitsCounter++;

            uint result = Convert.ToUInt32(readBuffer < 128 ? 0 : 1);
            readBuffer <<= 1;

            return result;
        }

        public UInt32 ReadNBits(UInt32 n)
        {
            UInt32 result = 0;

            for (int i = 1; i <= n; i++)
            {
                result <<= 1;
                result = result | ReadBit();
            }

            return result;
        }

        public void Dispose()
        {
            inputFile.Dispose();
        }
    }
}
