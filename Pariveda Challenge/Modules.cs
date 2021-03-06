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
    public partial class Modules : Form
    {
        Students viewStudent = new Students();
        string studentName;

        public Modules(string studentName)
        {
            this.studentName = studentName;
            InitializeComponent();
        }

        private void buttonTerms_Click(object sender, EventArgs e)
        {
            ModulesTerms showTerms = new ModulesTerms();
            if (showTerms.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            ModulesQuiz showQuiz = new ModulesQuiz(studentName);
            if (showQuiz.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Modules_Load(object sender, EventArgs e)
        {

        }
    }
}
