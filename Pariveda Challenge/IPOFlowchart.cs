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
    public partial class IPOFlowchart : Form
    {
        public IPOFlowchart()
        {
            InitializeComponent();
        }

        private void IPOFlowchart_Load(object sender, EventArgs e)
        {

        }

        private void buttonTerms_Click(object sender, EventArgs e)
        {

        }

        private void buttonVisuals_Click(object sender, EventArgs e)
        {
            IPOFlowchartVisuals showVisuals = new IPOFlowchartVisuals();
            if (showVisuals.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            IPOFlowchartQuiz showQuiz = new IPOFlowchartQuiz();
            if (showQuiz.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
