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
    public partial class IPOFlowchartQuiz : Form
    {
        public static int countCorrect;

        Students viewStudent = new Students();
        string studentName;

        public IPOFlowchartQuiz(string studentName)
        {
            this.studentName = studentName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countCorrect = 0;

            if (comboBox1.Text == "d. algorithm")
            {
                countCorrect++;
            }
            if (comboBox2.Text == "b. pseudocode")
            {
                countCorrect++;
            }
            if (comboBox3.Text == "b. parallelogram")
            {
                countCorrect++;
            }
            if (comboBox4.Text == "c. string")
            {
                countCorrect++;
            }
            if (comboBox5.Text == "a. variable")
            {
                countCorrect++;
            }
            if (comboBox6.Text == "b. assignment statement")
            {
                countCorrect++;
            }
            if (comboBox7.Text == "d. variable declaration")
            {
                countCorrect++;
            }
            if (comboBox8.Text == "c. input, process, output")
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
            outfile.WriteLine(studentName + " answered " + countCorrect + " questions correctly on the IPO and Flowchart quiz");

            outfile.Close();

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IPOFlowchartQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
