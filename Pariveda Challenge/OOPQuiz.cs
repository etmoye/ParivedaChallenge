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
    public partial class OOPQuiz : Form
    {
        Students viewStudent = new Students();
        string studentName;
        public static int countCorrect;

        public OOPQuiz(string studentName)
        {
            this.studentName = studentName;
            InitializeComponent();
        }

        private void OOPQuiz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            countCorrect = 0;

            if (comboBox1.Text == "b. procedural")
            {
                countCorrect++;
            }
            if (comboBox2.Text == "d. object-oriented")
            {
                countCorrect++;
            }
            if (comboBox3.Text == "c. field")
            {
                countCorrect++;
            }
            if (comboBox4.Text == "d. accessor")
            {
                countCorrect++;
            }
            if (comboBox5.Text == "d. mutator")
            {
                countCorrect++;
            }
            if (comboBox6.Text == "b. constructor")
            {
                countCorrect++;
            }
            if (comboBox7.Text == "b. no arguments")
            {
                countCorrect++;
            }
            if (comboBox8.Text == "d. both b and c")
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
            outfile.WriteLine(studentName + " answered " + countCorrect + " questions correctly on the OOP quiz");

            outfile.Close();

        }
    }
}
