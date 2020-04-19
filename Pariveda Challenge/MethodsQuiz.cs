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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    countCorrect = 0;

        //    if (comboBox1.Text == "A")
        //    {
        //        countCorrect++;
        //    }
           
        //    if (comboBox2.Text == "A")
        //    {
        //        countCorrect++;
        //    }
        //    if (comboBox3.Text == "A")
        //    {
        //        countCorrect++;
        //    }
        //    if (comboBox4.Text == "A")
        //    {
        //        countCorrect++;
        //    }

        //    MessageBox.Show("You correctly answered " + countCorrect + " questions");


       // }

        private void MethodsQuiz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            countCorrect = 0;

            if (comboBox1.Text == "b. library function")
            {
                countCorrect++;
            }
            if (comboBox2.Text == "a. development, reusability")
            {
                countCorrect++;
            }
            if (comboBox3.Text == "a. header")
            {
                countCorrect++;
            }
            if (comboBox4.Text == "c. body")
            {
                countCorrect++;
            }
            if (comboBox5.Text == "d. return")
            {
                countCorrect++;
            }
            if (comboBox6.Text == "a. call")
            {
                countCorrect++;
            }
            if (comboBox7.Text == "b. parameters")
            {
                countCorrect++;
            }
            if (comboBox8.Text == "d. void")
            {
                countCorrect++;
            }

            MessageBox.Show("You answered " + countCorrect + " questions correctly");

        }
    }
}
