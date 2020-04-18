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
    public partial class MethodsFunctions : Form
    {
        public MethodsFunctions()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    richTextBox1.Text = File.ReadAllText("quiz.txt");
        //    //OpenFileDialog openFile1 = new OpenFileDialog();
        //    //// openFile1.Filter = "quiz|*.txt";
        //    //openFile1.FileName = "quiz.txt";
        //    //if(openFile1.ShowDialog() == DialogResult.OK)
        //    //{
        //    //    richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
        //    //}

        //    //string text = File.ReadAllText("quiz.txt");
        //    //// openFile1.Filter = "quiz|*.txt";
        //    ////openFile1.FileName = "quiz.txt";
        //    //if (text.ShowDialog() == DialogResult.OK)
        //    //{
        //    //    richTextBox1.LoadFile(text,RichTextBoxStreamType.PlainText);
        //    //}
        //}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    richTextBox1.Text = File.ReadAllText("MethodsFunctionsCode.txt");
        //}

        private void buttonTerms_Click(object sender, EventArgs e)
        {

        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            txbIntro1.Visible = false;
            txbIntro2.Visible = false;
            txbIntro3.Visible = false;
            txbIntro4.Visible = false;
            txbIntro5.Visible = false;

            richTextBoxMethodsCode.Visible = true;
            richTextBoxMethodsCode.Text = File.ReadAllText("MethodsFunctionsCode.txt");

        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            MethodsQuiz showQuiz = new MethodsQuiz();
            if (showQuiz.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonIntro_Click(object sender, EventArgs e)
        {
            txbIntro1.Visible = true;
            txbIntro2.Visible = true;
            txbIntro3.Visible = true;
            txbIntro4.Visible = true;
            txbIntro5.Visible = true;

            richTextBoxMethodsCode.Visible = false;

        }

        private void MethodsFunctions_Load(object sender, EventArgs e)
        {

        }
    }
}
