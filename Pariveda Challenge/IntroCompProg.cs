﻿using System;
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
    public partial class IntroCompProg : Form
    {
        public IntroCompProg()
        {
            InitializeComponent();
        }

        private void buttonTerms_Click(object sender, EventArgs e)
        {
            IntroTerms showTerms = new IntroTerms();
            if (showTerms.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            IntroQuiz showQuiz = new IntroQuiz();
            if(showQuiz.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void IntroCompProg_Load(object sender, EventArgs e)
        {

        }
    }
}
