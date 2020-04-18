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
    public partial class StudentLogin : Form
    {
        //////Students viewStudent;
       // Students currentStudents;
        private Students currentStudent;
        StudentUtilities studentUtils;
        

        public StudentLogin(Object tempStudent)
        {
            currentStudent = (Students)tempStudent;
            //currentStudent = new Students[500];
            InitializeComponent();
            studentUtils = new StudentUtilities();


        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Students[] currentStudents = new Students[100];
            // Students viewStudent =  (Students);
            currentStudent.studentName = textBoxName.Text;
            currentStudent.studentCwid = textBoxCwid.Text;
            currentStudent.studentClass = comboBoxClass.Text;
            currentStudent.studentEmail = textBoxEmail.Text;

            //string saveStudent = currentStudent.ToString();

            //WORKS KIND OF studentUtils.SaveStudents();
            //this morning commented studentUtils.SaveStudents();

            //////copy and pasted
            StreamWriter outfile = new StreamWriter("CurrentStudents.txt", true); //("output.txt", true) use if you want to pick up a file where you left off
            outfile.WriteLine(currentStudent.studentName + "-" + currentStudent.studentCwid + "-" + currentStudent.studentClass + "-" + currentStudent.studentEmail); // " should show student");
           //okay way too much, just trying to print one line at a time
            //for (int i = 0; i < Students.GetCount(); i++) //fix limit - JUST FOR TESTING 
           // {
            //    //VIEWSTUDENT HAS NO VALUE
            //    // outfile.WriteLine("is this getting here"); - IS NOT GETTING HERE
                 //outfile.WriteLine(currentStudents[i].ToFile());
            //    //outfile.WriteLine(
            //    //Listing.IncCount();

           // }
            //outfile.Write(viewStudent[Students.GetCount() - 1].ToFile());

            outfile.Close();
            ////////
            DialogResult dialogResult = MessageBox.Show("Student saved.", "Save", MessageBoxButtons.OK);

        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
