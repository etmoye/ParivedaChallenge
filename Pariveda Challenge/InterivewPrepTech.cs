using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pariveda_Challenge
{
    public partial class InterivewPrepTech : Form
    {
        public InterivewPrepTech()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxFizzBuzz.Visible = true;
            pictureBox1.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxFizzBuzz.Visible = false;
            pictureBox1.Visible = true;
        }
    }
}
