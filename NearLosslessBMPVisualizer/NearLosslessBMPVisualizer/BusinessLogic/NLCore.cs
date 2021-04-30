using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearLosslessBMPVisualizer
{
    class NearLosslessEngine
    {
        public int minValueError =  255;
        public int maxValueError = -255;
        private byte[,] decodedImage   = new byte[256, 256];
        private byte[,] originalImage  = new byte[256, 256];
        private byte[,] predictedImage = new byte[256, 256];

        private int[,]  errorPredictedImage = new int[256, 256];
        private int[,]  errorPredictedQuantizedImage = new int[256, 256];



        public NearLosslessEngine(byte[,] originalImageMatrix)
        {
            if (originalImageMatrix.Length != originalImage.Length)
            {
                throw new InvalidOperationException("Original image matrix must be of size 256x256!");
            }
            else
            {
                int size = (int)Math.Sqrt(originalImage.Length);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        decodedImage[i, j] = 0;
                        predictedImage[i, j] = 0;
                        errorPredictedImage[i, j] = 0;
                        errorPredictedQuantizedImage[i, j] = 0;
                        originalImage[i, j] = originalImageMatrix[i, j];
                    }
                }
            }
        }

        public void CompressImage(int inputPredictorSelection, int maxReconstructionError)
        {
            int size = (int)Math.Sqrt(originalImage.Length);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    predictedImage[i, j] = PredictFromDecodedImageBasedOnSelection(i, j, inputPredictorSelection);
                    errorPredictedImage[i, j] = originalImage[i, j] - predictedImage[i, j];
                    errorPredictedQuantizedImage[i, j] = (int)Math.Floor((errorPredictedImage[i, j] + maxReconstructionError) /( 2 * maxReconstructionError + 1.0));

                    var temp = predictedImage[i, j] + errorPredictedQuantizedImage[i, j] * (2 * maxReconstructionError + 1);
                    if (temp > 255) temp = 255;
                    if (temp < 0) temp = 0;
                    decodedImage[i, j] = (byte)temp;

                    temp = originalImage[i, j] - decodedImage[i, j];
                    if (temp > maxValueError) maxValueError = temp;
                    if (temp < minValueError) minValueError = temp;
                }
            }
        }
        
        private byte PredictFromDecodedImageBasedOnSelection(int i, int j, int predictorSelection)
        {
            if (i == 0 && j == 0) return 128;
            if (i == 0) return decodedImage[i, j - 1];
            if (j == 0) return decodedImage[i - 1, j];

            switch (predictorSelection)
            {
                case 0: return 128;
                case 1: return decodedImage[i, j - 1];      // A
                case 2: return decodedImage[i - 1, j];      // B
                case 3: return decodedImage[i - 1, j - 1];  // C
                case 4:                                     // A + B - C
                    {
                        var temp = decodedImage[i, j - 1] + decodedImage[i - 1, j] - decodedImage[i - 1, j - 1];
                        if (temp > 255) temp = 255;
                        if (temp < 0) temp = 0;
                        return (byte)temp;
                    }
                case 5:                                     // A + (B - C) / 2
                    {
                        var temp = decodedImage[i, j - 1] + (decodedImage[i - 1, j] - decodedImage[i - 1, j - 1]) / 2;
                        if (temp > 255) temp = 255;
                        if (temp < 0) temp = 0;
                        return (byte)temp;
                    }
                case 6:                                     // B + (A - C) / 2
                    {
                        var temp = decodedImage[i - 1, j] + (decodedImage[i, j - 1] - decodedImage[i - 1, j - 1]) / 2;
                        if (temp > 255) temp = 255;
                        if (temp < 0) temp = 0;
                        return (byte)temp;
                    }
                case 7:                                     // (A + B) / 2
                    {
                        var temp = (decodedImage[i - 1, j] + decodedImage[i, j - 1]) / 2;
                        if (temp > 255) temp = 255;
                        if (temp < 0) temp = 0;
                        return (byte)temp;
                    }
                case 8:                                     // JpegLS
                    {
                        if (decodedImage[i - 1, j - 1] >= Math.Max(decodedImage[i - 1, j], decodedImage[i, j - 1]))
                            return Math.Min(decodedImage[i - 1, j], decodedImage[i, j - 1]);

                        if (decodedImage[i - 1, j - 1] <= Math.Min(decodedImage[i - 1, j], decodedImage[i, j - 1]))
                            return Math.Max(decodedImage[i - 1, j], decodedImage[i, j - 1]);

                        var temp = decodedImage[i, j - 1] + (decodedImage[i - 1, j] - decodedImage[i - 1, j - 1]) / 2;
                        if (temp > 255) temp = 255;
                        if (temp < 0) temp = 0;
                        return (byte)temp;
                    }

                default:
                    break;
            }
            return 128;
        }




        
    }
}
