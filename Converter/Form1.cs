using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text Files (*.txt)|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtIn.Text = System.IO.File.ReadAllText(fd.FileName);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
