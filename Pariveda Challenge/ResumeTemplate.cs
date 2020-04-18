using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pariveda_Challenge
{
    public partial class ResumeTemplate : Form
    {
        public ResumeTemplate()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //private void richTextBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
