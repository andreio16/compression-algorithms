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

namespace ArithmeticCoder
{
    public partial class MainForm : Form
    {
        private string inputFilePath = @"";
        private string outputFilePath = @"";

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var info = new FileInfo(ofd.FileName);
                textBoxInputPath.Text = ofd.FileName;
                textBoxOutput.Text += $"> {ofd.SafeFileName} opened successfully! [{info.Length} bytes]\r\n";
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            inputFilePath = textBoxInputPath.Text;

            if (File.Exists(inputFilePath))
            {
                outputFilePath = Path.ChangeExtension(inputFilePath, ".ac");
                Coder.CompressFile(inputFilePath, outputFilePath);
                textBoxOutput.Text += $"> Compression done!\r\n";
            }
            else
                MessageBox.Show("File doesn't exist.");
        }

    }
}
