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
        private int writeBitsCounter = 1;
        private byte writeBuffer = 0;

        public BitWriter(string filePath)
        {
            outputFile = new FileStream(filePath, FileMode.Open);
        }

        private static byte BitToBeWritten(uint value)
        {
            return (byte)(value % 2);
        }

        private void WriteBit(UInt32 value)
        {
            writeBuffer <<= 1;
            writeBuffer |= BitToBeWritten(value);

            if (writeBitsCounter % 8 == 0)
            {
                outputFile.WriteByte(writeBuffer);
                writeBuffer = 0;
            }
            else
            {
                writeBitsCounter++;
            }

        }

        public void WriteNBits(UInt32 value, int numOfBits) // n <= 32 
        {
            if (numOfBits > 32)
            {
                throw new Exception("Numarul de biti care trebuie scris depaseste 32");
            }

            for (int k = numOfBits - 1; k >= 0; k--)
            {
                WriteBit(value >> k);
            }
        }

        public void Dispose()
        {
            outputFile.Dispose();
        }
    }
}
