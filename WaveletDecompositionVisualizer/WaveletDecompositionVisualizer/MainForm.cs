using System;
using System.IO;
using System.Windows.Forms;
using WaveletDecompositionVisualizer.IOLib;
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

        private void btnSaveEncodedWVL_Click(object sender, EventArgs e)
        {
            try
            {
                if (bmpObject == null)
                    throw new NullReferenceException();

                var headerBmpFile = bmpObject.GetBmpHeader();
                var size = (int)Math.Sqrt(waveletImage.Length);
                var saveFileName  = "\\" + Path.GetFileNameWithoutExtension(inputFilePathEncoder) + ".wvl";
                
                using (var fbd = new FolderBrowserDialog())
                {
                    var result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        var compressedFilePath = fbd.SelectedPath + saveFileName;

                        // Building the bmp compressed file format
                        BitWriter writer = new BitWriter(compressedFilePath);

                        // Writing the specific header byte by byte
                        for (int i = 0; i < headerBmpFile.Length; i++)
                            writer.WriteNBits(headerBmpFile[i], 8);

                        // Writing wvl data matrix elements
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                writer.WriteNBits((uint)(Math.Round(waveletImage[i, j])), 8);
                            }
                        }
                        writer.WriteNBits(1, 7);
                        writer.Dispose();
                    }
                }

                //using (var fbd = new FolderBrowserDialog())
                //{
                //    var result = fbd.ShowDialog();
                //    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                //    {
                //        var compressedFilePath = fbd.SelectedPath + saveFileName;
                //        using (Stream writer = new FileStream(compressedFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                //        {
                //            using (BinaryWriter binaryWriter = new BinaryWriter(writer))
                //            {
                //                for (int i = 0; i < size; i++)
                //                    for (int j = 0; j < size; j++)
                //                        binaryWriter.Write(waveletImage[i,j]);
                //            }
                //        }
                //    }
                //}

                MessageBox.Show("Image succesfully saved!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load the image first!");
            }
        }

        private void btnAnH1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bmpObject == null)
                    throw new NullReferenceException();

                DoAnalysisHorizontal(512);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load image first!");
            }
        }

        private void btnAnV1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bmpObject == null)
                    throw new NullReferenceException();

                DoAnalysisVertical(512);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load image first!");
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

        private void DoAnalysisVertical(int size)
        {
            for (int i = 0; i < size; i++)
            {
                var line = Helpers.ExtractLineX(i, waveletImage);
                var codedLine = wvlEngine.MakeAnalysis(line, size);
                Helpers.UpdateLineX(i, codedLine.ToArray(), ref waveletImage);
            }

            numericUpDownX.Value = size;
            numericUpDownY.Value = size / 2;
            btnShowWavelet_Click(null, null);
        }
        #endregion


        #region Form Designer Methods -- DECODER
        private void btnLoadWVL_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Wavelet (*wvl)|*.wvl";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFilePathWavelet = ofd.FileName;

                bmpObject = Helpers.ReadBmpFormat(inputFilePathWavelet);
                waveletImage = bmpObject.GetBmpFloatData();
                pictureBoxWaveletImage.Image = Helpers.BuildBitmapFromMatrix(waveletImage);
            }


        }

        private void btnSyH1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bmpObject == null)
                    throw new NullReferenceException();

                DoSynthesisHorizontal(512);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load image first!");
            }
        }

        private void btnSyV1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bmpObject == null)
                    throw new NullReferenceException();

                DoSynthesisVertical(512);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load image first!");
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

        private void DoSynthesisVertical(int size)
        {
            for (int i = 0; i < size; i++)
            {
                var line = Helpers.ExtractLineX(i, waveletImage);
                var decodedLine = wvlEngine.MakeSynthesis(line, size);
                Helpers.UpdateLineX(i, decodedLine.ToArray(), ref waveletImage);
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
                if (bmpObject == null)
                    throw new NullReferenceException();

                waveletImage = bmpObject.GetBmpFloatData();

                numericUpDownX.Value = numericUpDownX.Maximum;
                numericUpDownY.Value = numericUpDownY.Maximum;
                pictureBoxWaveletImage.Image = Helpers.BuildBitmapFromMatrix(waveletImage);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load image first!");
            }
        }

        private void btnShowWavelet_Click(object sender, EventArgs e)
        {
            try
            {
                if (bmpObject == null)
                    throw new NullReferenceException();

                var x = (int)numericUpDownX.Value;
                var y = (int)numericUpDownY.Value;
                var offset = (int)numericUpDownOffset.Value;
                var scale = (float)numericUpDownScale.Value;
                pictureBoxWaveletImage.Image = Helpers.BuildBitmapFromMatrix(waveletImage, x, y, offset, scale);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load image first!");
            }
        }

        private void btnVerifyError_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helpers.HasAllValuesZeros(BmpFileObject.auxImage))
                    throw new NullReferenceException();

                var min = int.MaxValue;
                var max = int.MinValue;
                var size = (int)Math.Sqrt(BmpFileObject.auxImage.Length);

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        var errorValue = (int)(BmpFileObject.auxImage[i, j] - Math.Round(waveletImage[i, j]));
                        if (errorValue < min)
                            min = errorValue;
                        if (errorValue > max)
                            max = errorValue;
                    }
                }
                textBoxMinErrorValue.Text = min.ToString();
                textBoxMaxErrorValue.Text = max.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please load both .bmp and .wvl images!");
            }
        }

        #endregion


    }
}
