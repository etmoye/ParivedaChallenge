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
    public partial class StructuresQuiz : Form
    {
        public static int countCorrect;
        public StructuresQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countCorrect = 0;

            if (comboBox1.Text == "c. decision")
            {
                countCorrect++;
            }
            if (comboBox2.Text == "b. single alternative")
            {
                countCorrect++;
            }
            if (comboBox3.Text == "a. relational")
            {
                countCorrect++;
            }
            if (comboBox4.Text == "b. OR")
            {
                countCorrect++;
            }
            if (comboBox5.Text == "d. count")
            {
                countCorrect++;
            }
            if (comboBox6.Text == "d. iteration")
            {
                countCorrect++;
            }
            if (comboBox7.Text == "c. initialize")
            {
                countCorrect++;
            }
            if (comboBox8.Text == "a. priming read")
            {
                countCorrect++;
            }

            MessageBox.Show("You answered " + countCorrect + " questions correctly");
        }
    }
}
