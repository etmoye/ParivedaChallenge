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
    public partial class LoginReport : Form
    {
        Students[] viewStudents;
        public LoginReport()
        {
            viewStudents = new Students[50];
            InitializeComponent();
        }

        private void LoginReport_Load(object sender, EventArgs e)
        {
            
            LoginTracker();
            richTextBox1.Text = File.ReadAllText("LoginReport.txt");
        }



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

            for (int i = 1; i < Students.GetCount(); i++)
            {
                if (viewStudents[i].GetStudentName() == currentStudent)
                {
                    outFile.WriteLine(viewStudents[i].ToString());
                    loginCount++;

                }
                else
                {
                    outFile.WriteLine("Student: " + currentStudent + "\n\tNumber of Logins: " + loginCount);
                    currentStudent = viewStudents[i].GetStudentName();
                    loginCount = 1;
                }
            }
            outFile.WriteLine("Student: " + currentStudent + "\n\tNumber of Logins: " + loginCount);
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



        ////////////////////////////
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
    }
}
