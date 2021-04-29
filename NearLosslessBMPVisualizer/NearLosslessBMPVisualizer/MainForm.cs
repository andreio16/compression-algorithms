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
        private string inputFilePathToCompress  = @"";
        private string outputFilePathToCompress = @"";

        private string inputFilePathToDecompress  = @"";
        private string outputFilePathToDecompress = @"";

        public MainForm()
        {
            InitializeComponent();
            comboBoxHistogram.SelectedIndex = 0;
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
                inputFilePathToCompress = ofd.FileName;
                BmpFileObject bmpObject = Helpers.ReadBmpFormat(inputFilePathToCompress);
                pictureBoxOriginalImage.Image = bmpObject.GetBmpImage();

                // orig img/ header/ bmp

                Helpers.DrawHistogram(pictureBoxHistogram, Helpers.CreateHistogram(bmpObject.GetBmpData()));
            }
        }

    }
}
