using System;
using System.Windows.Forms;
using System.Drawing;  

namespace NearLosslessBMPVisualizer
{

    public static class Helpers
    {
        public static BmpFileObject ReadBmpFormat(string filePath)
        {
            return new BmpFileObject(filePath);
        }
    }

    public class BmpFileObject
    {
        private byte[,] _dataContainer = new byte[256, 256];
        private byte[] _headerContainer = new byte[1078];
        private Bitmap _image = new Bitmap(256, 256);

        public BmpFileObject(string filePath)
        {
            BitReader reader = new BitReader(filePath);

            for (int i = 0; i < _headerContainer.Length; i++)
                _headerContainer[i] = (byte)reader.ReadNBits(8);

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    _dataContainer[i, j] = (byte)reader.ReadNBits(8);
                    _image.SetPixel(j, 255 - i, Color.FromArgb(_dataContainer[i, j], _dataContainer[i, j], _dataContainer[i, j]));
                }
            }

            reader.Dispose();
        }

        public byte[,] GetBmpData()
        {
            return _dataContainer;
        }

        public byte[] GetBmpHeader()
        {
            return _headerContainer;
        }

        public Bitmap GetBmpImage()
        {
            return _image;
        }
    }
}
