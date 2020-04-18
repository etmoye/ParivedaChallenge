using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;


namespace Pariveda_Challenge
{
    public partial class ProfessionalDev : Form
    {
        public ProfessionalDev()
        {
            InitializeComponent();
        }

        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCompany.Text == "Acuity Brands")
            {
                Acuity showAcuity = new Acuity();
                if (showAcuity.ShowDialog() == DialogResult.OK)
                {

                }
            }
            if (comboBoxCompany.Text == "Pariveda Solutions")
            {
                Pariveda showPariveda = new Pariveda();
                if (showPariveda.ShowDialog() == DialogResult.OK)
                {

                }

            }

            if (comboBoxCompany.Text == "Crowe")
            {
                Crowe showCrowe = new Crowe();
                if (showCrowe.ShowDialog() == DialogResult.OK)
                {

                }

            }

            if (comboBoxCompany.Text == "CGI")
            {
                CGI showCGI = new CGI();
                if (showCGI.ShowDialog() == DialogResult.OK)
                {

                }

            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelAIMS.Visible = true;
            comboBoxCompany.Visible = true;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                labelAIMS.Visible = false;
                comboBoxCompany.Visible = false;
                InterviewPrepBehav showBehavioral = new InterviewPrepBehav();
                if (showBehavioral.ShowDialog() == DialogResult.OK)
                {

                }
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                labelAIMS.Visible = false;
                comboBoxCompany.Visible = false;
                InterivewPrepTech showTech = new InterivewPrepTech();
                if(showTech.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                labelAIMS.Visible = false;
                comboBoxCompany.Visible = false;
                ResumeTemplate showResume = new ResumeTemplate();
                if (showResume.ShowDialog() == DialogResult.OK)
                {

                }
            }

        }

    }       
}
