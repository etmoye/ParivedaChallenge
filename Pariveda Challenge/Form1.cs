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
    public partial class Form1 : Form
    {
        Students viewStudent = new Students();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random professor = new Random();
            int prof = professor.Next(1,3);
            if (prof == 1)
            {
                //showJeff1.BringToFront();
                ProfJeff showJeff = new ProfJeff();

                if (showJeff.ShowDialog() == DialogResult.OK)
                {

                }

            }
            if (prof == 2)
            {
                ProfDanish showDanish = new ProfDanish();
                if (showDanish.ShowDialog() == DialogResult.OK)
                {

                }
            }
            button1.Hide();
            showProfessor(prof);
        }

        private void showProfessor(int prof)
        {
            if(prof == 1)
            {
                showJeff1.BringToFront();
                //pictureJeff.Visible = true;
                //picture1.Visible = true;
                //picture2.Visible = true;
                //picture3.Visible = true;
                //picture4.Visible = true;
                //picture5.Visible = true;
                //richTextBoxJeff1.Visible = true;
                //richTextBoxJeff2.Visible = true;
                //richTextBoxJeff3.Visible = true;
                //richTextBoxJeff4.Visible = true;
                //richTextBoxJeff5.Visible = true;


            }
            if(prof == 2)
            {
                showDanish1.BringToFront();
                //pictureDanish.Visible = true;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTopics_Click(object sender, EventArgs e)
        {
            Topics showTopics = new Topics();
            if (showTopics.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonPD_Click(object sender, EventArgs e)
        {
            ProfessionalDev proDev = new ProfessionalDev();
            if (proDev.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrimsonMailLogin showEmail = new CrimsonMailLogin();
            if(showEmail.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void showJeff1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Students[] viewStudents = new Students[100];
            StudentLogin showStudentProfile = new StudentLogin(viewStudent);
            if (showStudentProfile.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProfessorLogin showProfLogin = new ProfessorLogin();
            if (showProfLogin.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
