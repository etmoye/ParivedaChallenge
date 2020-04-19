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
using System.Drawing;

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
            //LoadStudents();
            //StudentUtilities.GetAllStudents();
            //listBox1.DataSource = viewStudents;

            // StreamReader inFile = new StreamReader("CurrentStudents.txt");
            // string input = inFile.ReadLine();
            // string[] tempArray = input.Split('-');
            // //listBox1.DataSource = tempArray;

            //// viewStudents[Students.GetCount()] = new Students(tempArray[0], tempArray[1], tempArray[2], tempArray[3]);

            //// viewStudents.ToList();
            // //Students.IncCount();
            // //listBox1.DataSource = viewStudents;

            // // for(int i = 0; i<Students.GetCount(); i++)
            // while(input!=null)
            // {
            //         tempArray = input.Split('-');
            //         viewStudents[Students.GetCount()] = new Students(tempArray[0], tempArray[1], tempArray[2], tempArray[3]);
            // //     //Students.IncCount();
            //         input = inFile.ReadLine();
            // }
            // inFile.Close();
            //viewStudents = GetAllStudents();

            GetAllStudents();                                                                                                                                                     //
            listBox1.DataSource = viewStudents;
            //
            //Sort();
           
            LoginTracker();
           
            
            richTextBox1.Text = File.ReadAllText("LoginReport.txt");

            ////streamreader
            //listBox1.DataSource = viewStudents;
        }

        //public void LoadStudents()
        //{
        //    //Students.SetCount(0);

        //    StreamReader inFile = new StreamReader("CurrentStudents.txt");
        //    string input = inFile.ReadLine();

        //    while(!inFile.EndOfStream)
        //    {
        //        string[] tempArray = input.Split('-');
        //        viewStudents[Students.GetCount()] = new Students(tempArray[0], tempArray[1], tempArray[2], tempArray[3]);
        //       // Students.IncCount();
        //    }
        //    inFile.Close();

        //    //streamreader
        //    listBox1.DataSource = viewStudents;
        //}

        public void GetAllStudents()
        {
            StreamReader inFile = new StreamReader("CurrentStudents.txt");
            string input = inFile.ReadLine();
           // string[] tempArray = input.Split('-');
            //listBox1.DataSource = tempArray;

            // viewStudents[Students.GetCount()] = new Students(tempArray[0], tempArray[1], tempArray[2], tempArray[3]);

            // viewStudents.ToList();
            //Students.IncCount();
            //listBox1.DataSource = viewStudents;

            // for(int i = 0; i<Students.GetCount(); i++)
            while (input != null)
            {
                string[] tempArray = input.Split('-');
                viewStudents[Students.GetCount()] = new Students(tempArray[0], tempArray[1], tempArray[2], tempArray[3]);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoginReport showReport = new LoginReport();
            //if (showReport.ShowDialog() == DialogResult.OK)
            //{

            //}
            richTextBox1.Visible = true;
            label1.Visible = false;
            labelName.Visible = false;
            labelCWID.Visible = false;
            labelClass.Visible = false;
            labelEmail.Visible = false;
            textBoxName.Visible = false;
            textBoxCWID.Visible = false;
            textBoxClass.Visible = false;
            textBoxEmail.Visible = false;
            button1.Visible = false;
            listBox1.Visible = false;
               
           // richTextBox1.BringToFront = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           // richTextBox1.Text = File.ReadAllText("LoginReport.txt");
            // //Students[] viewStudents = new Students[50];
            // StreamReader inFile = new StreamReader("LoginReport.txt");
            // string input = inFile.ReadToEnd();
            // richTextBox1.Text = File.ReadAllText(inFile);
            //// Globals.notes = richTextBox1.Text;
        }



        ///////////////////////////////////////////////////////////////////

        public void LoginTracker()
        {

            ///////Sort
            StreamWriter sort = new StreamWriter("sort.txt");
            sort.WriteLine("this should sort: ");

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
                // sort.WriteLine(viewStudents[i]);
            }

            //StreamWriter sort = new StreamWriter("sort.txt");
            // sort.WriteLine(viewStudents);

            sort.Close();

            //////////////////////////////
            string currentStudent = viewStudents[0].GetStudentName();
            int loginCount = 1;
            StreamWriter outFile = new StreamWriter("LoginReport.txt");

            // outFile.WriteLine(viewStudents[0].ToString());
            // GetAllStudents();
            //outFile.WriteLine("Student\t\t\t\t\t\tLogin Count");

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

        public void Sort()
        {
            for (int i = 0; i < Students.GetCount() - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j > Students.GetCount(); j++)
                {
                    if (viewStudents[min].GetStudentName().CompareTo(viewStudents[j].GetStudentName()) < 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Swap(min, i);
                }
            }
        }

        public void Swap(int x, int y)
        {
            Students temp = viewStudents[x];
            viewStudents[x] = viewStudents[y];
            viewStudents[y] = temp;
        }
    }
}
