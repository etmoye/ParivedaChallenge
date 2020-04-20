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
    public partial class Topics : Form
    {
        ///
        Students viewStudent = new Students();
        ///
        string studentName;
        ///
        public Topics(string studentName)
        {
            //
            this.studentName = studentName;
            InitializeComponent();
        }

        private void buttonMethodsAndFunctions_Click(object sender, EventArgs e)
        {
            MethodsFunctions showModule = new MethodsFunctions(studentName);
            if (showModule.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonArrays_Click(object sender, EventArgs e)
        {
            Arrays showArrays = new Arrays(studentName);
            if (showArrays.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonIntro_Click(object sender, EventArgs e)
        {
            IntroCompProg showIntro = new IntroCompProg(studentName);
            if(showIntro.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonIPOFlowchart_Click(object sender, EventArgs e)
        {
            IPOFlowchart showIPOFlowchart = new IPOFlowchart(studentName);
            if (showIPOFlowchart.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonModules_Click(object sender, EventArgs e)
        {
            Modules showModules = new Modules(studentName);
            if (showModules.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonAsk_Click(object sender, EventArgs e)
        {
            CrimsonMailLogin showEmail = new CrimsonMailLogin();
            if (showEmail.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonDecisionRepetitionStructures_Click(object sender, EventArgs e)
        {
            Structures showStructures = new Structures(studentName);
            if (showStructures.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonFileHandling_Click(object sender, EventArgs e)
        {
            FileHandling showFileHandling = new FileHandling(studentName);
            if (showFileHandling.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Topics_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonOOP_Click(object sender, EventArgs e)
        {
            OOP showOOP = new OOP(studentName);
            if (showOOP.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
