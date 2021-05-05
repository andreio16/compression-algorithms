using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearLosslessBMPVisualizer
{
    public class BitWriter : IDisposable
    {
        private FileStream outputFile;
        private int writeBitsCounter = 0;
        private byte writeBuffer = 0;

        public BitWriter(string filePath)
        {
            outputFile = new FileStream(filePath, FileMode.OpenOrCreate);
        }

        private void WriteBit(uint value)
        {
            writeBuffer  = (byte)(writeBuffer << 1);
            writeBuffer |= BitToBeWritten(value);

            writeBitsCounter++;
            // Check if buffer is full
            if (writeBitsCounter == 8)
            {
                outputFile.WriteByte(Convert.ToByte(writeBuffer));
                writeBitsCounter = 0;
                writeBuffer = 0;
            }
        }

        public void WriteNBits(uint value, int numOfBits) // n <= 32 
        {
            if (numOfBits > 32)
            {
                throw new Exception("Numarul de biti care trebuie scris depaseste 32");
            }

            for (int i = numOfBits-1; i >=0 ; i--)
            {
                // Take first bit
                uint bit = 0;
                int mask = 1 << (i);
                bit = (uint)((value & mask) >> i);
                WriteBit(bit);
            }
        }

        private static byte BitToBeWritten(uint value)
        {
            return (byte)(value % 2);
        }

        public void Dispose()
        {
            outputFile.Dispose();
        }
    }
}