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
    public partial class Arrays : Form
    {
        public Arrays()
        {
            InitializeComponent();
        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            ArraysQuiz showQuiz = new ArraysQuiz();
            if (showQuiz.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
