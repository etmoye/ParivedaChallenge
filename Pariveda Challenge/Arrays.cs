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
    public partial class Arrays : Form
    {
        Students viewStudent = new Students();
        string studentName;

        public Arrays(string studentName)
        {
            this.studentName = studentName;
            InitializeComponent();
        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            ArraysQuiz showQuiz = new ArraysQuiz(studentName);
            if (showQuiz.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Arrays_Load(object sender, EventArgs e)
        {
            arraysLogicCode1.Visible = false;
        }

        private void buttonTerms_Click(object sender, EventArgs e)
        {
            arraysLogicCode1.Visible = true;
        }

        private void buttonIntro_Click(object sender, EventArgs e)
        {
            arraysLogicCode1.Visible = false;
        }
    }
}
