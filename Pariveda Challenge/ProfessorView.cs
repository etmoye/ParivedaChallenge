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
    public partial class ProfessorView : Form
    {
        Students[] viewStudents;
        public ProfessorView()
        {
            viewStudents = new Students[50];
            InitializeComponent();
        }

        private void ProfessorView_Load(object sender, EventArgs e)
        {
            

            GetAllStudents();                                                                                                                                                     //
            listBox1.DataSource = viewStudents;


            LoginTracker();
            richTextBoxLogins.Text = File.ReadAllText("LoginReport.txt");
           
        }

      

        public void GetAllStudents()
        {
            StreamReader inFile = new StreamReader("CurrentStudents.txt");
            string input = inFile.ReadLine();
       

            // for(int i = 0; i<Students.GetCount(); i++)
            while (input != null)
            {
                string[] tempArray = input.Split('-');
                viewStudents[Students.GetCount()] = new Students(tempArray[0], tempArray[1], tempArray[2], tempArray[3], tempArray[4]);
                Students.IncCount();
                input = inFile.ReadLine();
            }
            inFile.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Students viewStudent = (Students)listBox1.SelectedItem;
            textBoxName.Text = viewStudent.studentName;
            textBoxCWID.Text = viewStudent.studentCwid;
            textBoxClass.Text = viewStudent.studentClass;
            textBoxEmail.Text = viewStudent.studentEmail;
            textBoxTime.Text = viewStudent.loginTime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            richTextBoxLogins.Visible = true;
            label1.Visible = false;
            labelName.Visible = false;
            labelCWID.Visible = false;
            labelClass.Visible = false;
            labelEmail.Visible = false;
            labelTime.Visible = false;
            textBoxName.Visible = false;
            textBoxCWID.Visible = false;
            textBoxClass.Visible = false;
            textBoxEmail.Visible = false;
            textBoxTime.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            buttonReturn.Visible = true;
            buttonClose.Visible = false;
            listBox1.Visible = false;
               
           // richTextBox1.BringToFront = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richTextBox1.Text = File.ReadAllText("LoginReport.txt");
            ////Students[] viewStudents = new Students[50];
            //StreamReader inFile = new StreamReader("LoginReport.txt");
            //string input = inFile.ReadToEnd();
            //richTextBox1.Text = File.ReadAllText(inFile);
            ////Globals.notes = richTextBox1.Text;
        }



        ///////////////////////////////////////////////////////////////////

        public void LoginTracker()
        {

            ///////Sort
            for (int i = 0; i < Students.GetCount() - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < Students.GetCount(); j++)
                {
                    if (viewStudents[min].GetStudentName().CompareTo(viewStudents[j].GetStudentName()) > 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Swap(min, i);
                }
                
            }

          

            //////////////////////////////
            string currentStudent = viewStudents[0].GetStudentName();
            int loginCount = 1;
            StreamWriter outFile = new StreamWriter("LoginReport.txt");

          
           
           

            for (int i = 1; i < Students.GetCount(); i++)
            {
                
                if (viewStudents[i].GetStudentName() == currentStudent)
                {
                   // outFile.WriteLine(viewStudents[i].ToString());
                    loginCount++;

                }
                else
                {
                    outFile.WriteLine(currentStudent + " has logged in " + loginCount + " times.\n");
                    currentStudent = viewStudents[i].GetStudentName();
                    loginCount = 1;
                }
            }
            //outFile.WriteLine("Student: " + currentStudent + "\tNumber of Logins: " + loginCount + "\n");
            outFile.WriteLine(currentStudent + " has logged in " + loginCount + " times.\n");
            outFile.Close();
        }


        

        public void Swap(int x, int y)
        {
            Students temp = viewStudents[x];
            viewStudents[x] = viewStudents[y];
            viewStudents[y] = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBoxQuiz.Text = File.ReadAllText("QuizResults.txt");
            richTextBoxQuiz.Visible = true;
            richTextBoxLogins.Visible = false;
            label1.Visible = false;
            labelName.Visible = false;
            labelCWID.Visible = false;
            labelClass.Visible = false;
            labelEmail.Visible = false;
            labelTime.Visible = false;
            textBoxName.Visible = false;
            textBoxCWID.Visible = false;
            textBoxClass.Visible = false;
            textBoxEmail.Visible = false;
            textBoxTime.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            buttonReturn.Visible = true;
            buttonClose.Visible = false;
            listBox1.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            richTextBoxQuiz.Visible = false;
            richTextBoxLogins.Visible = false;
            label1.Visible = true;
            labelName.Visible = true;
            labelCWID.Visible = true;
            labelClass.Visible = true;
            labelEmail.Visible = true;
            labelTime.Visible = true;
            textBoxName.Visible = true;
            textBoxCWID.Visible = true;
            textBoxClass.Visible = true;
            textBoxEmail.Visible = true;
            textBoxTime.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            buttonClose.Visible = true;
            buttonReturn.Visible = false;
            listBox1.Visible = true;

        }
    }
}
