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
    public partial class Structures : Form
    {
        Students viewStudent = new Students();
        string studentName;

        public Structures(string studentName)
        {
            this.studentName = studentName;
            InitializeComponent();
        }

        private void txbDecision2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDecision1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTerms_Click(object sender, EventArgs e)
        {
            decisionStructure1.SendToBack();
            repetitionStructure1.BringToFront();
            //txbDecision1.Visible = false;
            //txbDecision2.Visible = false;
            //txbDecision3.Visible = false;
            //txbDecision4.Visible = false;
            //txbDecision5.Visible = false;
        }

        private void buttonIntro_Click(object sender, EventArgs e)
        {
            decisionStructure1.BringToFront();
            repetitionStructure1.SendToBack();
            //txbDecision1.Visible = true;
            //txbDecision2.Visible = true;
            //txbDecision3.Visible = true;
            //txbDecision4.Visible = true;
            //txbDecision5.Visible = true;
        }

        private void Structures_Load(object sender, EventArgs e)
        {
            decisionStructure1.BringToFront();
            repetitionStructure1.SendToBack();
        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            StructuresQuiz showQuiz = new StructuresQuiz(studentName);
            if (showQuiz.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
