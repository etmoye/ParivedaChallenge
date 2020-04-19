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
    public partial class FileHandling : Form
    {
        public FileHandling()
        {
            InitializeComponent();
        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            FileHandlingQuiz showQuiz = new FileHandlingQuiz();
            if (showQuiz.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonTerms_Click(object sender, EventArgs e)
        {
            fileHandlingCode1.Visible = true;
        }

        private void buttonIntro_Click(object sender, EventArgs e)
        {
            fileHandlingCode1.Visible = false;
        }
    }
}
