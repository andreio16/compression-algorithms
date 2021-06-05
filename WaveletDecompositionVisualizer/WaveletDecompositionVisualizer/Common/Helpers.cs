using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using WaveletDecompositionVisualizer.IOLib;

namespace WaveletDecompositionVisualizer.Common
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
        private Bitmap _image;
        private byte[,] _dataContainer;
        private byte[] _headerContainer = new byte[1078];
        public static byte[,] auxOriginalImage = new byte[512, 512];

        public Bitmap GetBmpImage()
        {
            return _image;
        }

        public byte[] GetBmpHeader()
        {
            return _headerContainer;
        }

        public byte[,] GetBmpData()
        {
            return _dataContainer;
        }

        public BmpFileObject(string filePath)
        {
            _image = new Bitmap(512, 512);
            _dataContainer = new byte[512, 512];
            BitReader reader = new BitReader(filePath);

            for (int i = 0; i < _headerContainer.Length; i++)
                _headerContainer[i] = (byte)reader.ReadNBits(8);

            for (int i = 0; i < 512; i++)
            {
                for (int j = 0; j < 512; j++)
                {
                    _dataContainer[i, j] = (byte)reader.ReadNBits(8);
                    _image.SetPixel(j, 511 - i, Color.FromArgb(_dataContainer[i, j], _dataContainer[i, j], _dataContainer[i, j]));
                }
            }

            reader.Dispose();
        }
    }

}
