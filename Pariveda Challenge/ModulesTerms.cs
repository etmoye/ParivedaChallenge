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
    public partial class ModulesTerms : Form
    {
        public ModulesTerms()
        {
            InitializeComponent();
        }

        private void ModulesTerms_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("ModulesTerminology.txt");
        }
    }
}
