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
        private WaveletCore wvlEngine;
        private BmpFileObject bmpObject;

        private string inputFilePathEncoder = @"";
        private string inputFilePathWavelet = @"";

        public MainForm()
        {
            InitializeComponent();
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
                BmpFileObject.auxOriginalImage = bmpObject.GetBmpData();
            }
        }
    }
}
