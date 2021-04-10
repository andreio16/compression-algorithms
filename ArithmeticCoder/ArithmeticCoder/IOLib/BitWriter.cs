using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoder
{
    class BitWriter : IDisposable
    {
        private FileStream outputFile;
        private int writeBitsCounter = 0;
        private int writeBuffer = 0;

        public BitWriter(string filePath)
        {
            outputFile = new FileStream(filePath, FileMode.OpenOrCreate);
        }

        private void WriteBit(uint bit)
        {
            bit &= 1;
            if (writeBitsCounter == 7) 
            {
                writeBuffer |= ((int)bit << writeBitsCounter);
                outputFile.WriteByte(Convert.ToByte(writeBuffer));
                writeBitsCounter = 0;
                writeBuffer = 0;
            }
            else
            {
                writeBuffer |= ((int)bit << writeBitsCounter);
                writeBitsCounter++;
            }
        }

        public void WriteNBits(uint value, int numOfBits) // n <= 32 
        {
            if (numOfBits > 32)
            {
                throw new Exception("Numarul de biti care trebuie scris depaseste 32");
            }

            for (int i = 0; i < numOfBits; i++)
            {
                WriteBit(value);
                value >>= 1;
            }
        }


        public void Dispose()
        {
            outputFile.Dispose();
        }
    }
}