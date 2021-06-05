using System;
using System.Windows.Forms;
using WaveletDecompositionVisualizer.Common;

namespace WaveletDecompositionVisualizer
{
    public partial class MainForm : Form
    {
        private BmpFileObject bmpObject;
        private string inputFilePathEncoder = @"";
        private string inputFilePathWavelet = @"";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadBMP_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFilePathEncoder = ofd.FileName;
                bmpObject = Helpers.ReadBmpFormat(inputFilePathEncoder);
                pictureBoxOriginalImage.Image = bmpObject.GetBmpImage();
                BmpFileObject.auxOriginalImage = bmpObject.GetBmpData();
            }
        }
    }
}
