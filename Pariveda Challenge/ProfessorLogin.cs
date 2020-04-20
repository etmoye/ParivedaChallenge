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
    public partial class ProfessorLogin : Form
    {
        public ProfessorLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "rolltide" && textBoxUsername.Text == "jlucas" || textBoxUsername.Text == "dsaifee")
            {
                
                ProfessorView showProfView = new ProfessorView();
                if (showProfView.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Error", MessageBoxButtons.OK);
            }
            this.Close();
        }

        private void ProfessorLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
