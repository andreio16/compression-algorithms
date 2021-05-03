using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NearLosslessBMPVisualizer
{
    public partial class MainForm : Form
    {
        private string inputFilePathEncoder  = @"";
        private string inputFilePathDecoder  = @"";

        private bool isFileEncoded = false;

        private int userPredictorSelection = 0;
        private int userKMaxReconstructionError = 1;

        private BmpFileObject bmpObject;
        private NearLosslessEngine nlEngine;

        public MainForm()
        {
            InitializeComponent();
            comboBoxSaveMode.SelectedIndex  = 0;
            comboBoxPredictorSelection.SelectedIndex = 0;
        }

        //-----------------------------------------------------------------------------------------------------------------------
        //  Form Designer Methods
        //-----------------------------------------------------------------------------------------------------------------------
        private void btnLoadBMP_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFilePathEncoder = ofd.FileName;
                bmpObject = Helpers.ReadBmpFormat(inputFilePathEncoder);
                pictureBoxOriginalImage.Image = bmpObject.GetBmpImage();

                // orig img/ header/ bmp -> global
                
                Helpers.DrawHistogram(pictureBoxHistogram, Helpers.CreateHistogram(bmpObject.GetBmpData()), (float)numericUpDownHistogramScale.Value);
            }
        }

        private void btnEncodeOriginalImage_Click(object sender, EventArgs e)
        {
            userKMaxReconstructionError = (int)numericUpDownKValue.Value;

            switch (comboBoxPredictorSelection.SelectedIndex)
            {
                case 1: userPredictorSelection = 1; break;
                case 2: userPredictorSelection = 2; break;
                case 3: userPredictorSelection = 3; break;
                case 4: userPredictorSelection = 4; break;
                case 5: userPredictorSelection = 5; break;
                case 6: userPredictorSelection = 6; break;
                case 7: userPredictorSelection = 7; break;
                case 8: userPredictorSelection = 8; break;
                default: userPredictorSelection = 0; break;
            }
            
            nlEngine = new NearLosslessEngine(bmpObject.GetBmpData());
            nlEngine.CompressImage(userPredictorSelection, userKMaxReconstructionError);
            textBoxMinErrorValue.Text = nlEngine.minValueError.ToString();
            textBoxMaxErrorValue.Text = nlEngine.maxValueError.ToString();
            MessageBox.Show("Image was encoded succesfully!");
            isFileEncoded = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                var scale = (float)numericUpDownHistogramScale.Value;

                switch (comboBoxHistogram.SelectedIndex)
                {
                    case 0: Helpers.DrawHistogram(pictureBoxHistogram, Helpers.CreateHistogram(nlEngine.GetOriginalImageMatrix()), scale);  break;
                    case 1: Helpers.DrawHistogram(pictureBoxHistogram, Helpers.CreateHistogram(nlEngine.GetErrorPredictedMatrix()), scale); break;
                    case 2: Helpers.DrawHistogram(pictureBoxHistogram, Helpers.CreateHistogram(nlEngine.GetErrorPredictedQuantizedMatrix()), scale); break;
                    case 3: Helpers.DrawHistogram(pictureBoxHistogram, Helpers.CreateHistogram(nlEngine.GetDecodedImageMatrix()), scale);   break;
                    default: Helpers.DrawHistogram(pictureBoxHistogram, Helpers.CreateHistogram(bmpObject.GetBmpData()), scale); break;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error, you forgot to load or to encode the image!");
            }
        }

        private void btnRefreshErrorImage_Click(object sender, EventArgs e)
        {
            try
            {
                var contrast = (int)numericUpDownErrorImageContrast.Value;

                switch (comboBoxErrorImage.SelectedIndex)
                {
                    case 0: pictureBoxErrorImage.Image = Helpers.BuildBitmapFromMatrix(nlEngine.GetErrorPredictedMatrix(), contrast); break;
                    case 1: pictureBoxErrorImage.Image = Helpers.BuildBitmapFromMatrix(nlEngine.GetErrorPredictedQuantizedMatrix(), contrast); break;
                    default: break;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error, you forgot to load or to encode the image!");
            }
        }

        private void btnSaveEncodedImage_Click(object sender, EventArgs e)
        {
            try
            {
                var headerBmpFile = bmpObject.GetBmpHeader();
                var compressedDataMatrix = nlEngine.GetErrorPredictedQuantizedMatrix();
                var dataMatrixSize = (int)Math.Sqrt(compressedDataMatrix.Length);

                var compressedFileName = Path.GetFileName(inputFilePathEncoder);
                var fileExtension  = ".k" + userKMaxReconstructionError + "p" + userPredictorSelection;
                

                if (userKMaxReconstructionError != numericUpDownKValue.Value) throw new NullReferenceException();
                if (userPredictorSelection != comboBoxPredictorSelection.SelectedIndex) throw new NullReferenceException();
                if (String.IsNullOrEmpty(compressedFileName) || isFileEncoded == false) throw new NullReferenceException();

                using (var fbd = new FolderBrowserDialog())
                {
                    var result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        var compressedFilePath = fbd.SelectedPath;
                        switch (comboBoxSaveMode.SelectedIndex)
                        {
                            case 0: // Fixed Saving Mode (F)
                                {
                                    fileExtension += "F.nlp";
                                    compressedFilePath += "\\" + compressedFileName + fileExtension;

                                    // Building the bmp compressed file format
                                    BitWriter writer  = new BitWriter(compressedFilePath);

                                    // [1] writing the specific header byte by byte
                                    for (int i = 0; i < headerBmpFile.Length; i++)
                                        writer.WriteNBits(headerBmpFile[i], 8);

                                    // [2] writing the predictor used (on 4 bits)
                                    writer.WriteNBits((uint)userPredictorSelection, 4);

                                    // [3] writing the k  value  used (on 4 bits)
                                    writer.WriteNBits((uint)userKMaxReconstructionError, 4);

                                    // [4] writing the save mode used (on 2 bits)
                                    writer.WriteNBits((uint)comboBoxSaveMode.SelectedIndex, 2);

                                    // [5] writing bmp data matrix elements (on 9 bits each)
                                    for (int i = 0; i < dataMatrixSize; i++)
                                    {
                                        for (int j = 0; j < dataMatrixSize; j++)
                                        {
                                            writer.WriteNBits((uint)(compressedDataMatrix[i, j] + 255), 9);
                                        }
                                    }
                                    break;
                                }
                            case 1: // Jpeg Table Saving Mode (T)
                                {
                                    fileExtension += "T.nlp";
                                    compressedFilePath += "\\" + compressedFileName + fileExtension;
                                    break;
                                }
                            case 2: // Arithmetic Saving Mode (Entropic Coder) (A)
                                {
                                    fileExtension += "A.nlp";
                                    compressedFilePath += "\\" + compressedFileName + fileExtension;
                                    break;
                                }
                            default: break;
                        }
                    }
                }
                isFileEncoded = false;
                MessageBox.Show("Encoded image succesfully saved!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load/encode the image. (Other causes: encoding settings are changed)");
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------
    }
}
