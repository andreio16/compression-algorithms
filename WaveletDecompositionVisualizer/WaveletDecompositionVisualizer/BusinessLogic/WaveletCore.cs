using System;
using System.Linq;
using System.Collections.Generic;
using WaveletDecompositionVisualizer.Common;

namespace WaveletDecompositionVisualizer.BusinessLogic
{
    class WaveletCore
    {
        #region Wavelet Filters
        private float[] _analysisL ={
             0.026748757411f,
            -0.016864118443f,
            -0.078223266529f,
             0.266864118443f,
             0.602949018236f,
             0.266864118443f,
            -0.078223266529f,
            -0.016864118443f,
             0.026748757411f
        };
        private float[] _analysisH =  {
             0.000000000000f,
             0.091271763114f,
            -0.057543526229f,
            -0.591271763114f,
             1.115087052457f,
            -0.591271763114f,
            -0.057543526229f,
             0.091271763114f,
             0.000000000000f
        };
        private float[] _synthesisL = {
             0.000000000000f,
            -0.091271763114f,
            -0.057543526229f,
             0.591271763114f,
             1.115087052457f,
             0.591271763114f,
            -0.057543526229f,
            -0.091271763114f,
             0.000000000000f
        };
        private float[] _synthesisH = {
             0.026748757411f,
             0.016864118443f,
            -0.078223266529f,
            -0.266864118443f,
             0.602949018236f,
            -0.266864118443f,
            -0.078223266529f,
             0.016864118443f,
             0.026748757411f
        };
        #endregion

        private readonly int filterSize  = 9;
        private readonly int paddingSize = 4;

        private List<float> BuildSyntesisVector(float[] lineLH, int length)
        {
            var lowUpSampleList = new List<float>();
            for (int i = 0; i < length / 2; i++)
            {
                lowUpSampleList.Add(lineLH[i]);
                lowUpSampleList.Add(0);
            }

            var highUpSampleList = new List<float>();
            for (int i = length / 2; i < length; i++)
            {
                highUpSampleList.Add(0);
                highUpSampleList.Add(lineLH[i]);
            }

            lowUpSampleList  = Helpers.AddReverseNElementsPadding(lowUpSampleList.ToArray(), paddingSize);
            highUpSampleList = Helpers.AddReverseNElementsPadding(highUpSampleList.ToArray(), paddingSize);

            var reconstructedResult = new List<float>();
            for (int lineIndex = 0; lineIndex < length; lineIndex++)
            {
                float lowValue = 0.0f, highValue = 0.0f;

                for (int windowIndex = 0; windowIndex < filterSize; windowIndex++)
                {
                    lowValue  += lowUpSampleList[lineIndex + windowIndex]  * _synthesisL[windowIndex];
                    highValue += highUpSampleList[lineIndex + windowIndex] * _synthesisH[windowIndex];
                }
                reconstructedResult.Add(lowValue + highValue);
            }
            return reconstructedResult;
        }

        private List<float> BuildAnalysisVectorLowHigh(float[] line, int length)
        {
            var lowConvolutionList = new List<float>();
            var highConvolutionList = new List<float>();
            var processedLine = Helpers.AddReverseNElementsPadding(line, paddingSize);

            // Compute Convolution between processedLine and analysis filters (H) and (L)
            for (int lineIndex = 0; lineIndex < length; lineIndex++)
            {
                float lowValue = 0.0f, highValue = 0.0f;

                for (int windowIndex = 0; windowIndex < filterSize; windowIndex++)
                {
                    lowValue += processedLine[lineIndex + windowIndex] * _analysisL[windowIndex];
                    highValue += processedLine[lineIndex + windowIndex] * _analysisH[windowIndex];
                }
                lowConvolutionList.Add(lowValue);
                highConvolutionList.Add(highValue);
            }

            var resultVector = new List<float>();
            // Down Sample L
            for (int i = 0; i < lowConvolutionList.Count; i += 2)
                resultVector.Add(lowConvolutionList[i]);
            // Down Sample H
            for (int i = 1; i < highConvolutionList.Count; i += 2)
                resultVector.Add(highConvolutionList[i]);

            return resultVector;
        }

        public List<float> MakeSynthesis(float[] inputVector, int length) { return BuildSyntesisVector(inputVector, length); }

        public List<float> MakeAnalysis(float[] inputVector, int length) { return BuildAnalysisVectorLowHigh(inputVector, length); }
        
    }
}
