using System;
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
        private string outputFilePathEncoder = @"";
        private string inputFilePathDecoder  = @"";
        private string outputFilePathDecoder = @"";

        private int userPredictorSelection = 0;
        private int userKMaxReconstructionError = 1;

        BmpFileObject bmpObject;
        NearLosslessEngine nlEngine;

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

    }
}
