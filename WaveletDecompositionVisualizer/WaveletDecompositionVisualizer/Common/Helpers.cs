using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using WaveletDecompositionVisualizer.IOLib;
using WaveletDecompositionVisualizer.BusinessLogic;

namespace WaveletDecompositionVisualizer.Common
{
    public static class Helpers
    {
        public static BmpFileObject ReadBmpFormat(string filePath)
        {
            return new BmpFileObject(filePath);
        }

        public static Bitmap BuildBitmapFromMatrix(float[,] dataMatrix)
        {
            int size = (int)Math.Sqrt(dataMatrix.Length);
            Bitmap image = new Bitmap(size, size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var value = (int)dataMatrix[i, j]; 
                    if (value > 255) value = 255;
                    if (value < 0) value = 0;
                    image.SetPixel(i, j, Color.FromArgb(value, value, value));
                }
            }

            return image;
        }

        public static Bitmap BuildBitmapFromMatrix(float[,] dataMatrix, int x, int y, int offset, float scale)
        {
            int size = (int)Math.Sqrt(dataMatrix.Length);
            Bitmap result = new Bitmap(size, size);

            for (int i = 0; i < size; i++) 
            {
                for (int j = 0; j < size; j++)
                {
                    // no scaling for the left corner [delimited by x & y]
                    if (i <= x && j <= y)
                    {
                        var value = (int)dataMatrix[i, j];
                        if (value > 255) value = 255;
                        if (value < 0) value = 0;
                        result.SetPixel(i, j, Color.FromArgb(value, value, value));  //j, size - 1 - i
                    }
                    else // apply scaling in the rest of matrix
                    {
                        var value = (int)(dataMatrix[i, j] * scale + offset);
                        if (value > 255) value = 255;
                        if (value < 0) value = 0;
                        result.SetPixel(i, j, Color.FromArgb(value, value, value));
                    }
                }
            }

            return result;
        }

        public static List<float> AddReverseNElementsPadding(float[] list, int nrOfPaddingElements)
        {
            var result = new List<float>(list);

            var frontPadding = list.ToList().GetRange(1, nrOfPaddingElements);

            var backPadding = list.ToList().GetRange(list.Length - nrOfPaddingElements - 1, nrOfPaddingElements);

            for (int i = 0, j = nrOfPaddingElements - 1; i < nrOfPaddingElements; i++, j--) 
            {
                result.Insert(0, frontPadding[i]);
                result.Add(backPadding[j]);
            }

            return result;
        }

        public static float[] ExtractColumnX(int x, float[,] matrix)
        {
            var size = (int)Math.Sqrt(matrix.Length);
            var column = new float[size];

            for (int i = 0; i < size; i++)
                column[i] = matrix[i, x];

            return column;
        }

        public static float[] ExtractLineX(int x, float[,] matrix)
        {
            var size = (int)Math.Sqrt(matrix.Length);
            var line = new float[size];

            for (int i = 0; i < size; i++)
                line[i] = matrix[x, i];

            return line;
        }

        public static void UpdateColumnX(int x, float[] column, ref float[,] matrix)
        {
            var size = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < size; i++)
                matrix[i, x] = column[i];
        }

        public static void UpdateLineX(int x, float[] line, ref float[,] matrix)
        {
            var size = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < size; i++)
                matrix[x, i] = line[i];
        }

        public static bool HasAllValuesZeros(byte[,] matrix)
        {
            var size = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] != 0)
                        return false;
                }
            }
            return true;
        }
    }
    

    public class BmpFileObject
    {
        private Bitmap _image;
        private byte[,] _dataContainer;
        private byte[] _headerContainer = new byte[1078];
        public static byte[,] auxImage  = new byte[512, 512];

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

        public float[,] GetBmpFloatData()
        {
            float[,] result = new float[512, 512];
            int size = (int)Math.Sqrt(_dataContainer.Length);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = _dataContainer[i, j];
                }
            }
            return result;
        }

        public BmpFileObject(string filePath)
        {
            _image = new Bitmap(512, 512);
            _dataContainer = new byte[512, 512];
            
            BitReader reader = new BitReader(filePath);

            for (int i = 0; i < _headerContainer.Length; i++)
                _headerContainer[i] = (byte)reader.ReadNBits(8);

            for (int i = 511; i >= 0; i--)
            {
                for (int j = 0; j < 512; j++)
                {
                    _dataContainer[j, i] = (byte)reader.ReadNBits(8);
                    _image.SetPixel(j, i, Color.FromArgb(_dataContainer[j, i], _dataContainer[j, i], _dataContainer[j, i]));
                }
            }

            reader.Dispose();
        }
    }

}
