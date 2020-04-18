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
            
        }
    }
}
