using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NearLosslessBMPVisualizer
{

    public static class Helpers
    {
        public static BmpFileObject ReadBmpFormat(string filePath)
        {
            return new BmpFileObject(filePath);
        }
        
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
