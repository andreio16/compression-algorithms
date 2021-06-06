using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using WaveletDecompositionVisualizer.Common;
using WaveletDecompositionVisualizer.BusinessLogic;

namespace WaveletDecompositionVisualizer
{
    public partial class MainForm : Form
    {
        private BmpFileObject bmpObject;
        private string inputFilePathEncoder = @"";
        private string inputFilePathWavelet = @"";

        private WaveletCore wvlEngine = new WaveletCore();
        private float[,] waveletImage = new float[512, 512];

        public MainForm()
        {
            InitializeComponent();
        }

        #region Form Designer Methods -- ENCODER
        private void btnLoadBMP_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFilePathEncoder = ofd.FileName;
                bmpObject = Helpers.ReadBmpFormat(inputFilePathEncoder);
                pictureBoxOriginalImage.Image = bmpObject.GetBmpImage();

                BmpFileObject.auxImage = bmpObject.GetBmpData();

                waveletImage = bmpObject.GetBmpFloatData();
                pictureBoxWaveletImage.Image = Helpers.BuildBitmapFromMatrix(waveletImage);
            }
        }

        private void btnAnH1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(inputFilePathEncoder)) throw new NullReferenceException();

                DoAnalysisHorizontal(512);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load .bmp image first!");
            }
        }
        
        private void DoAnalysisHorizontal(int size)
        {
            for (int i = 0; i < size; i++)
            {
                var column = Helpers.ExtractColumnX(i, waveletImage);
                var codedColumn = wvlEngine.MakeAnalysis(column, size);
                Helpers.UpdateColumnX(i, codedColumn.ToArray(), ref waveletImage);
            }

            numericUpDownX.Value = size / 2;
            numericUpDownY.Value = size;
            btnShowWavelet_Click(null, null);
        }
        #endregion
        

        #region Form Designer Methods -- DECODER

        private void btnSyH1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(inputFilePathEncoder)) throw new NullReferenceException();

                DoSynthesisHorizontal(512);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load .bmp image first!");
            }
        }

        private void DoSynthesisHorizontal(int size)
        {
            for (int i = 0; i < size; i++)
            {
                var column = Helpers.ExtractColumnX(i, waveletImage);
                var decodedColumn = wvlEngine.MakeSynthesis(column, size);
                Helpers.UpdateColumnX(i, decodedColumn.ToArray(), ref waveletImage);
            }

            numericUpDownX.Value = size;
            numericUpDownY.Value = size;
            btnShowWavelet_Click(null, null);
        }
        #endregion


        #region UI Elements
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(inputFilePathEncoder)) throw new NullReferenceException();

                waveletImage = bmpObject.GetBmpFloatData();
                pictureBoxWaveletImage.Image = Helpers.BuildBitmapFromMatrix(waveletImage);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load .bmp image first!");
            }
        }

        private void btnShowWavelet_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(inputFilePathEncoder)) throw new NullReferenceException();
                var x = (int)numericUpDownX.Value;
                var y = (int)numericUpDownY.Value;
                var offset = (int)numericUpDownOffset.Value;
                var scale = (float)numericUpDownScale.Value;
                pictureBoxWaveletImage.Image = Helpers.BuildBitmapFromMatrix(waveletImage, x, y, offset, scale);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load .bmp image first!");
            }
        }
        #endregion
    }
}
