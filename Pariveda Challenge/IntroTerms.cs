using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pariveda_Challenge
{
    public partial class IntroTerms : Form
    {
        public IntroTerms()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IntroTerms_Load(object sender, EventArgs e)
        {

            richTextBox1.Text = File.ReadAllText("IntroTerminology.txt");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
