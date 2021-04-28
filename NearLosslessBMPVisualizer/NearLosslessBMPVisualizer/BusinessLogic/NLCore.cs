using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearLosslessBMPVisualizer
{
    class ComputeCompression
    {
        private byte[,] originalImageMatrix  = new byte[256, 256];
        private byte[,] predictedImageMatrix = new byte[256, 256];
        private int[,]  errorImageMatrix = new int[256, 256];
    }
}
