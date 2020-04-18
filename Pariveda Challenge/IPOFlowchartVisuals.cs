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
    public partial class IPOFlowchartVisuals : Form
    {
        public IPOFlowchartVisuals()
        {
            InitializeComponent();
        }

        private void radioButtonIPO_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxIPO.Visible = true;
            pictureBoxFlowchart.Visible = false;
        }

        private void radioButtonFlowchart_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxIPO.Visible = false;
            pictureBoxFlowchart.Visible = true;
        }

        private void IPOFlowchartVisuals_Load(object sender, EventArgs e)
        {
            radioButtonIPO.Checked = true;
        }
    }
}
