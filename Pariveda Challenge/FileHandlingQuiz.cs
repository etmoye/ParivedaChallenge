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
    public partial class FileHandlingQuiz : Form
    {

        public static int countCorrect;

        public FileHandlingQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countCorrect = 0;

            if (comboBox1.Text == "a. input file")
            {
                countCorrect++;
            }
            if (comboBox2.Text == "b. output file")
            {
                countCorrect++;
            }
            if (comboBox3.Text == "c. close the file")
            {
                countCorrect++;
            }
            if (comboBox4.Text == "a. text file")
            {
                countCorrect++;
            }
            if (comboBox5.Text == "d. sequential access")
            {
                countCorrect++;
            }
            if (comboBox6.Text == "c. direct access")
            {
                countCorrect++;
            }
            if (comboBox7.Text == "a. StreamReader")
            {
                countCorrect++;
            }
            if (comboBox8.Text == "a. field")
            {
                countCorrect++;
            }

            MessageBox.Show("You answered " + countCorrect + " questions correctly");
        }
    }
}
