using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NearLosslessBMPVisualizer
{

    public static class Helpers
    {
        public static int[] CreateHistogram(int[,] matrix)
        {
            List<int> temp = new List<int>();
            List<int> freq = new List<int>();

            int length = (int)Math.Sqrt(matrix.Length);
            int[] histogram = new int[2 * length];
            Array.Clear(histogram, 0, 2 * length);

            // Convert matrix to list
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    temp.Add(matrix[i, j]);

            // Count frequencies 
            foreach (var group in temp.GroupBy(o => o))
                freq.Add(group.Count());

            // Build histogram from 2 lists + shift X axis to the right to match interval [-255:255]
            temp = temp.Distinct().ToList();
            for (int i = 0; i < temp.Count; i++)
                histogram[(temp[i] + 255)] = freq[i];

            return histogram;
        }

        public static int[] CreateHistogram(byte[,] matrix)
        {
            List<int> temp = new List<int>();
            List<int> freq = new List<int>();

            int length = (int)Math.Sqrt(matrix.Length);
            int[] histogram = new int[2 * length];
            Array.Clear(histogram, 0, 2 * length);

            // Convert matrix to list
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    temp.Add(matrix[i, j]);

            // Count frequencies 
            foreach (var group in temp.GroupBy(o => o))
                freq.Add(group.Count());

            // Build histogram from 2 lists + shift X axis to the right to match interval [-255:255]
            temp = temp.Distinct().ToList();
            for (int i = 0; i < temp.Count; i++)
                histogram[(temp[i] + 255)] = freq[i];

            return histogram;
        }

        public static BmpFileObject ReadBmpFormat(string filePath)
        {
            return new BmpFileObject(filePath);
        }

        public static Bitmap BuildBitmapFromMatrix(byte[,] dataMatrix)
        {

            int size = (int)Math.Sqrt(dataMatrix.Length);
            Bitmap image = new Bitmap(size, size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var value = dataMatrix[i, j];
                    if (value > 255) value = 255;
                    if (value < 0) value = 0;
                    image.SetPixel(j, size - 1 - i, Color.FromArgb(value, value, value));
                }
            }

            return image;
        }

        public static Bitmap BuildBitmapFromMatrix(int[,] dataMatrix, int contrastValue)
        {
            int size = (int)Math.Sqrt(dataMatrix.Length);
            Bitmap image = new Bitmap(size, size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var value = dataMatrix[i, j] * contrastValue + 128;
                    if (value > 255) value = 255;
                    if (value < 0) value = 0;
                    image.SetPixel(j, size - 1 - i, Color.FromArgb(value, value, value));
                }
            }

            return image;
        }

        public static void DrawHistogram(PictureBox canvas, int[] histogram, float scale)
        {
            Bitmap temp = new Bitmap(histogram.Length, canvas.Size.Height); //  histogram.Length  (int)(canvas.Size.Height * 0.2)

            for (int i = 0; i < histogram.Length; i++)
            {
                int start = (int)(canvas.Size.Height - histogram[i] * scale);
                if (start < 0) start = 0;
                if (start > canvas.Size.Height) start = canvas.Size.Height;
                for (int point = start; point < canvas.Size.Height; point++)
                {
                    temp.SetPixel(i, point, Color.Gray);
                }
            }

            if (canvas.Image != null) 
                canvas.Image.Dispose();
            canvas.Image = temp;

        }
        
        public static BmpFileObject ReadEncodedBmpFormat(string filePath, ref int kReconstructError, ref int selectedPredictor, ref int saveMode)
        {
            return new BmpFileObject(filePath, ref kReconstructError, ref selectedPredictor, ref saveMode);
        }

        public static void WriteValueUsingJPEGTable(string filePath, int value)
        {
            BitWriter writer = new BitWriter(filePath);

            if (value == 0)
            {
                writer.WriteNBits(0, 1);
            }
            else
            {
                var lineNumber = (int)(Math.Log(Math.Abs(value), 2) + 1);
                writer.WriteNBits(1, lineNumber);
                writer.WriteNBits(0, 1);

                var index = value;
                if (index < 0)
                    index += (int)Math.Pow(2, lineNumber) - 1;
                writer.WriteNBits((uint)index, lineNumber);
            }
            writer.Dispose();
        }
    }

    public class BmpFileObject
    {
        private Bitmap  _image;
        private byte[,] _dataContainer;
        private  int[,] _dataContainerEncoded;
        private byte[]  _headerContainer = new byte[1078];

        public BmpFileObject(string filePath)
        {
            _image = new Bitmap(256, 256);
            _dataContainer = new byte[256, 256];
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
        
        public int[,] GetBmpDataEncoded()
        {
            return _dataContainerEncoded;
        }

        public BmpFileObject(string filePath, ref int kReconstructError, ref int selectedPredictor, ref int saveMode)
        {
            _dataContainerEncoded = new int[256, 256];
            BitReader reader = new BitReader(filePath);

            for (int i = 0; i < _headerContainer.Length; i++)
                _headerContainer[i] = (byte)reader.ReadNBits(8);

            selectedPredictor = (int)reader.ReadNBits(4);
            kReconstructError = (int)reader.ReadNBits(4);
            saveMode = (int)reader.ReadNBits(2);

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    _dataContainerEncoded[i, j] = (int)reader.ReadNBits(9) - 255;
                }
            }

            reader.Dispose();
        }

    }

}
