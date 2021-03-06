﻿using System;
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
    public partial class ArraysQuiz : Form
    {
        public static int countCorrect;

        Students viewStudent = new Students();
        string studentName;

        public ArraysQuiz(string studentName)
        {
            this.studentName = studentName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countCorrect = 0;

            if (comboBox1.Text == "a. element")
            {
                countCorrect++;
            }
            if (comboBox2.Text == "b. subscript")
            {
                countCorrect++;
            }
            if (comboBox3.Text == "d. 0")
            {
                countCorrect++;
            }
            if (comboBox4.Text == "c. size of array - 1")
            {
                countCorrect++;
            }
            if (comboBox5.Text == "a. sequential search")
            {
                countCorrect++;
            }
            if (comboBox6.Text == "b. brackets")
            {
                countCorrect++;
            }
            if (comboBox7.Text == "c. parallel arrays")
            {
                countCorrect++;
            }
            if (comboBox8.Text == "a. same")
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
            outfile.WriteLine(studentName + " answered " + countCorrect + " questions correctly on the Arrays quiz");

            outfile.Close();

        }
    }
}
