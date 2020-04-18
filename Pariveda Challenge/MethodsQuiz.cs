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
    public partial class MethodsQuiz : Form
    {
        public static int countCorrect;

        public MethodsQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countCorrect = 0;

            if (comboBox1.Text == "A")
            {
                countCorrect++;
            }
           
            if (comboBox2.Text == "A")
            {
                countCorrect++;
            }
            if (comboBox3.Text == "A")
            {
                countCorrect++;
            }
            if (comboBox4.Text == "A")
            {
                countCorrect++;
            }

            MessageBox.Show("You correctly answered " + countCorrect + " questions");


        }

        private void MethodsQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
