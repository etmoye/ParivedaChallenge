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
        public Topics()
        {
            InitializeComponent();
        }

        private void buttonMethodsAndFunctions_Click(object sender, EventArgs e)
        {
            MethodsFunctions showModule = new MethodsFunctions();
            if (showModule.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonArrays_Click(object sender, EventArgs e)
        {

        }

        private void buttonIntro_Click(object sender, EventArgs e)
        {
            IntroCompProg showIntro = new IntroCompProg();
            if(showIntro.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonIPOFlowchart_Click(object sender, EventArgs e)
        {
            IPOFlowchart showIPOFlowchart = new IPOFlowchart();
            if (showIPOFlowchart.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonModules_Click(object sender, EventArgs e)
        {
            Modules showModules = new Modules();
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
    }
}
