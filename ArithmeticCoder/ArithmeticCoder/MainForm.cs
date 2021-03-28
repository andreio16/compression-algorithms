using System;
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
        string path = @"C:\Users\Andrei\Desktop\bla.txt";

        public MainForm()
        {
            InitializeComponent();

            var writer = new BitWriter(path);
            writer.WriteNBits(23, 8);
            //bitWrite.WriteNBits(1, 7);
            writer.Dispose();

            var reader = new BitReader(path);
            uint value = reader.ReadNBits(8);
            label1.Text = String.Join(",", value);
        }
    }
}
