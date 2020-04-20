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
    public partial class StructuresQuiz : Form
    {
        public static int countCorrect;
        Students viewStudent = new Students();
        string studentName;

        public StructuresQuiz(string studentName)
        {
            this.studentName = studentName;
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

            MessageBox.Show("You answered " + countCorrect + " questions correctly", "Results");
            SaveResults(studentName, countCorrect);
            this.Close();
        }

        public void SaveResults(string studentnName, int countCorrect)
        {
            StreamWriter outfile = new StreamWriter("QuizResults.txt", true); //("output.txt", true) use if you want to append
            outfile.WriteLine(studentName + " answered " + countCorrect + " questions correctly on the Control Structures quiz");

            outfile.Close();

        }

        private void StructuresQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
