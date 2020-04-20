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
    public partial class IntroQuiz : Form
    {
        private static int countCorrect;
        Students viewStudent = new Students();
        ///
        string studentName;
        ///

        public IntroQuiz(string studentName)
        {
            this.studentName = studentName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countCorrect = 0;

            if(comboBox1.Text == "b. program")
            {
                countCorrect++;
            }
            if (comboBox2.Text == "a. hardware")
            {
                countCorrect++;
            }
            if (comboBox3.Text == "d. the CPU")
            {
                countCorrect++;
            }
            if (comboBox4.Text == "c. main memory")
            {
                countCorrect++;
            }
            if (comboBox5.Text == "a. RAM")
            {
                countCorrect++;
            }
            if (comboBox6.Text == "b. binary")
            {
                countCorrect++;
            }
            if (comboBox7.Text == "a. assembler")
            {
                countCorrect++;
            }
            if (comboBox8.Text == "a. syntax")
            {
                countCorrect++;
            }

            MessageBox.Show("You answered " + countCorrect + " questions correctly", "Results");
            SaveResults(studentName, countCorrect);
            this.Close();
        }

        public void SaveResults(string studentnName, int countCorrect)
        {
            StreamWriter outfile = new StreamWriter("QuizResults.txt", true); //("output.txt", true) use if you want to append
            outfile.WriteLine(studentName + " answered " + countCorrect + " questions correctly on the Computers and Programming quiz");

            outfile.Close();

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

        private void IntroQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
