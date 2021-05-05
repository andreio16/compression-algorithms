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
        private bool   isFileEncoded = false;
        private string inputFilePathEncoder  = @"";
        private string inputFilePathDecoder  = @"";


        private int decodingK  = 0;
        private int decodingP  = 0;
        private int decodingSM = 0;
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
        //  Form Designer Methods -- ENCODER
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
                    default:
                        if (bmpObject.GetBmpData() != null && bmpObject.GetBmpDataEncoded() == null)
                            Helpers.DrawHistogram(pictureBoxHistogram, Helpers.CreateHistogram(bmpObject.GetBmpData()), scale);
                        if (bmpObject.GetBmpDataEncoded() != null && bmpObject.GetBmpData() == null)
                            Helpers.DrawHistogram(pictureBoxHistogram, Helpers.CreateHistogram(bmpObject.GetBmpDataEncoded()), scale);
                        break;
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
                    default: pictureBoxErrorImage.Image = Helpers.BuildBitmapFromMatrix(nlEngine.GetDecodedImageMatrix()); break;
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

                var compressedFileName = Path.GetFileNameWithoutExtension(inputFilePathEncoder);
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
                                    BitWriter writer = new BitWriter(compressedFilePath);

                                    // [1-F] writing the specific header byte by byte
                                    for (int i = 0; i < headerBmpFile.Length; i++)
                                        writer.WriteNBits(headerBmpFile[i], 8);

                                    // [2-F] writing the predictor used (on 4 bits)
                                    writer.WriteNBits((uint)userPredictorSelection, 4);

                                    // [3-F] writing the k  value  used (on 4 bits)
                                    writer.WriteNBits((uint)userKMaxReconstructionError, 4);

                                    // [4-F] writing the save mode used (on 2 bits)
                                    writer.WriteNBits((uint)comboBoxSaveMode.SelectedIndex, 2);

                                    // [5-F] writing bmp data matrix elements (on 9 bits each)
                                    for (int i = 0; i < dataMatrixSize; i++)
                                    {
                                        for (int j = 0; j < dataMatrixSize; j++)
                                        {
                                            writer.WriteNBits((uint)compressedDataMatrix[i, j] + 255, 9);
                                        }
                                    }
                                    writer.WriteNBits(1, 7);
                                    writer.Dispose();
                                    break;
                                }
                            case 1: // Jpeg Table Saving Mode (T)
                                {
                                    fileExtension += "T.nlp";
                                    compressedFilePath += "\\" + compressedFileName + fileExtension;

                                    // Building the bmp compressed file format
                                    BitWriter writer = new BitWriter(compressedFilePath);

                                    // [1-T] writing the specific header byte by byte
                                    for (int i = 0; i < headerBmpFile.Length; i++)
                                        writer.WriteNBits(headerBmpFile[i], 8);

                                    // [2-T] writing the predictor used (on 4 bits)
                                    writer.WriteNBits((uint)userPredictorSelection, 4);

                                    // [3-T] writing the k  value  used (on 4 bits)
                                    writer.WriteNBits((uint)userKMaxReconstructionError, 4);

                                    // [4-T] writing the save mode used (on 2 bits)
                                    writer.WriteNBits((uint)comboBoxSaveMode.SelectedIndex, 2);
                                    
                                    // [5-T] writing bmp data matrix elements encoded with JPEG Table
                                    for (int i = 0; i < dataMatrixSize; i++)
                                    {
                                        for (int j = 0; j < dataMatrixSize; j++) 
                                        {
                                            Helpers.WriteValueUsingJPEGTable(writer, compressedDataMatrix[i, j]);
                                        }
                                    }
                                    writer.WriteNBits(1, 7);
                                    writer.Dispose();
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
        //  Form Designer Methods -- DECODER
        //-----------------------------------------------------------------------------------------------------------------------

        private void btnLoadDecoded_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "NearLosslesPredictor (*nlp)|*.nlp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                label15.Text = "Encoded Image";
                inputFilePathDecoder = ofd.FileName;
                bmpObject = Helpers.ReadEncodedBmpFormat(inputFilePathDecoder, ref decodingK, ref decodingP, ref decodingSM);

                // encoded  data/ header/ k/ p/ sm/  -> global 

                Helpers.DrawHistogram(pictureBoxHistogram, Helpers.CreateHistogram(bmpObject.GetBmpDataEncoded()), (float)numericUpDownHistogramScale.Value);
            }
        }

        private void btnDecodeImage_Click(object sender, EventArgs e)
        {
            nlEngine = new NearLosslessEngine(bmpObject.GetBmpDataEncoded());

            nlEngine.DecompressImage(decodingP, decodingK);

            pictureBoxDecodedImage.Image = Helpers.BuildBitmapFromMatrix(nlEngine.GetDecodedImageMatrix());

            MessageBox.Show("Image was decoded succesfully!");
            label15.Text = "Decoded Image";
        }

        private void btnSaveDecodedImage_Click(object sender, EventArgs e)
        {
            try
            {
                var fileExtension = ".bmp";
                var headerBmpFile = bmpObject.GetBmpHeader();
                var compressedDataMatrix = nlEngine.GetDecodedImageMatrix();
                var dataMatrixSize = (int)Math.Sqrt(compressedDataMatrix.Length);

                var decompressedFileName = Path.GetFileNameWithoutExtension(inputFilePathDecoder);
                
                if (String.IsNullOrEmpty(decompressedFileName)) throw new NullReferenceException();

                using (var fbd = new FolderBrowserDialog())
                {
                    var result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        var decompressedFilePath = fbd.SelectedPath;
                        
                        decompressedFilePath += "\\" + decompressedFileName + fileExtension;

                        // Building the bmp file format
                        BitWriter writer = new BitWriter(decompressedFilePath);

                        // [1] writing the specific header byte by byte
                        for (int i = 0; i < headerBmpFile.Length; i++)
                            writer.WriteNBits(headerBmpFile[i], 8);

                        // [2] writing bmp data matrix elements (on 9 bits each)
                        for (int i = 0; i < dataMatrixSize; i++)
                        {
                            for (int j = 0; j < dataMatrixSize; j++)
                            {
                                writer.WriteNBits((uint)compressedDataMatrix[i, j], 8);
                            }
                        }
                        writer.WriteNBits(1, 7);
                        writer.Dispose();
                    }
                }
                MessageBox.Show("Decoded image succesfully saved!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Warning: You forgot to load/decode the image before saving.");
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------
    }
}
