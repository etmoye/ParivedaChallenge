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
    public partial class OOP : Form
    {
        Students viewStudent = new Students();
        string studentName;

        public OOP(string studentName)
        {
            this.studentName = studentName;
            InitializeComponent();
        }

        private void OOP_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            OOPQuiz showQuiz = new OOPQuiz(studentName);
            if (showQuiz.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void txbIntro1_TextChanged(object sender, EventArgs e)
        {
            oopLogicCode1.Visible = false;
        }

        private void buttonTerms_Click(object sender, EventArgs e)
        {
            oopLogicCode1.Visible = true;
        }

        private void buttonIntro_Click(object sender, EventArgs e)
        {
            oopLogicCode1.Visible = false;
        }
    }
}
