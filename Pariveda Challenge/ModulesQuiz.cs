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
    public partial class ModulesQuiz : Form
    {
        private static int countCorrect;

        public ModulesQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countCorrect = 0;

            if (comboBox1.Text == "c. module")
            {
                countCorrect++;
            }
            if (comboBox2.Text == "d. header")
            {
                countCorrect++;
            }
            if (comboBox3.Text == "b. call")
            {
                countCorrect++;
            }
            if (comboBox4.Text == "b. local variable")
            {
                countCorrect++;
            }
            if (comboBox5.Text == "c. scope")
            {
                countCorrect++;
            }
            if (comboBox6.Text == "b. parameter")
            {
                countCorrect++;
            }
            if (comboBox7.Text == "c. pass an argument by value")
            {
                countCorrect++;
            }
            if (comboBox8.Text == "a. pass an argument by reference")
            {
                countCorrect++;
            }

            MessageBox.Show("You answered " + countCorrect + " questions correctly");
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbIntro4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
