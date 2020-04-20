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
        //Students viewStudent;
        //Students currentStudents;
        private Students currentStudent;
        
        

        public StudentLogin(Object tempStudent)
        {
            currentStudent = (Students)tempStudent;
            //currentStudent = new Students[500];
            InitializeComponent();
           


        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            //localDate.ToShortDateString();
            //localDate.ToShortTimeString();

            Students[] currentStudents = new Students[100];
            // Students viewStudent =  (Students);
            currentStudent.studentName = textBoxName.Text;
            currentStudent.studentCwid = textBoxCwid.Text;
            currentStudent.studentClass = comboBoxClass.Text;
            currentStudent.studentEmail = textBoxEmail.Text;
            currentStudent.loginTime = localDate.ToString();
            //string saveStudent = currentStudent.ToString();

            //WORKS KIND OF studentUtils.SaveStudents();
            //this morning commented studentUtils.SaveStudents();

           
            StreamWriter outfile = new StreamWriter("CurrentStudents.txt", true); //("output.txt", true) use if you want to append
            outfile.WriteLine(currentStudent.studentName + "-" + currentStudent.studentCwid + "-" + currentStudent.studentClass + "-" + currentStudent.studentEmail + "-" + currentStudent.loginTime); // " should show student");
         

            outfile.Close();
          
            DialogResult dialogResult = MessageBox.Show("Student saved.", "Save", MessageBoxButtons.OK);
            this.Close();
            //////now
            
            Form1 myForm = new Form1(currentStudent.studentName);
            if (myForm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                this.Close();
            }
            ////
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
