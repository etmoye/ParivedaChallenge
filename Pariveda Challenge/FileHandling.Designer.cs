﻿namespace Pariveda_Challenge
{
    partial class FileHandling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileHandling));
            this.txbIntro4 = new System.Windows.Forms.RichTextBox();
            this.txbIntro2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIntro1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuiz = new System.Windows.Forms.Button();
            this.buttonTerms = new System.Windows.Forms.Button();
            this.buttonIntro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileHandlingCode1 = new Pariveda_Challenge.FileHandlingCode();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbIntro4
            // 
            this.txbIntro4.BackColor = System.Drawing.SystemColors.Control;
            this.txbIntro4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIntro4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIntro4.Location = new System.Drawing.Point(308, 744);
            this.txbIntro4.Name = "txbIntro4";
            this.txbIntro4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbIntro4.Size = new System.Drawing.Size(1070, 137);
            this.txbIntro4.TabIndex = 26;
            this.txbIntro4.Text = resources.GetString("txbIntro4.Text");
            // 
            // txbIntro2
            // 
            this.txbIntro2.BackColor = System.Drawing.SystemColors.Control;
            this.txbIntro2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIntro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbIntro2.Location = new System.Drawing.Point(308, 459);
            this.txbIntro2.Name = "txbIntro2";
            this.txbIntro2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbIntro2.Size = new System.Drawing.Size(1070, 227);
            this.txbIntro2.TabIndex = 25;
            this.txbIntro2.Text = resources.GetString("txbIntro2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 55);
            this.label1.TabIndex = 24;
            this.label1.Text = "File Handling\r\n";
            // 
            // txbIntro1
            // 
            this.txbIntro1.BackColor = System.Drawing.SystemColors.Control;
            this.txbIntro1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIntro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbIntro1.Location = new System.Drawing.Point(308, 165);
            this.txbIntro1.Name = "txbIntro1";
            this.txbIntro1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbIntro1.Size = new System.Drawing.Size(1070, 275);
            this.txbIntro1.TabIndex = 23;
            this.txbIntro1.Text = resources.GetString("txbIntro1.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.buttonQuiz);
            this.panel1.Controls.Add(this.buttonTerms);
            this.panel1.Controls.Add(this.buttonIntro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 793);
            this.panel1.TabIndex = 27;
            // 
            // buttonQuiz
            // 
            this.buttonQuiz.BackColor = System.Drawing.Color.Black;
            this.buttonQuiz.FlatAppearance.BorderSize = 0;
            this.buttonQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonQuiz.ForeColor = System.Drawing.Color.White;
            this.buttonQuiz.Location = new System.Drawing.Point(77, 283);
            this.buttonQuiz.Name = "buttonQuiz";
            this.buttonQuiz.Size = new System.Drawing.Size(208, 64);
            this.buttonQuiz.TabIndex = 13;
            this.buttonQuiz.Text = "Quiz";
            this.buttonQuiz.UseVisualStyleBackColor = false;
            this.buttonQuiz.Click += new System.EventHandler(this.buttonQuiz_Click);
            // 
            // buttonTerms
            // 
            this.buttonTerms.BackColor = System.Drawing.Color.Black;
            this.buttonTerms.FlatAppearance.BorderSize = 0;
            this.buttonTerms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonTerms.ForeColor = System.Drawing.Color.White;
            this.buttonTerms.Location = new System.Drawing.Point(77, 191);
            this.buttonTerms.Name = "buttonTerms";
            this.buttonTerms.Size = new System.Drawing.Size(208, 64);
            this.buttonTerms.TabIndex = 14;
            this.buttonTerms.Text = "Code";
            this.buttonTerms.UseVisualStyleBackColor = false;
            this.buttonTerms.Click += new System.EventHandler(this.buttonTerms_Click);
            // 
            // buttonIntro
            // 
            this.buttonIntro.BackColor = System.Drawing.Color.Black;
            this.buttonIntro.FlatAppearance.BorderSize = 0;
            this.buttonIntro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonIntro.ForeColor = System.Drawing.Color.White;
            this.buttonIntro.Location = new System.Drawing.Point(77, 94);
            this.buttonIntro.Name = "buttonIntro";
            this.buttonIntro.Size = new System.Drawing.Size(208, 64);
            this.buttonIntro.TabIndex = 11;
            this.buttonIntro.Text = "Intro";
            this.buttonIntro.UseVisualStyleBackColor = false;
            this.buttonIntro.Click += new System.EventHandler(this.buttonIntro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1457, 123);
            this.panel2.TabIndex = 28;
            // 
            // fileHandlingCode1
            // 
            this.fileHandlingCode1.Location = new System.Drawing.Point(267, 123);
            this.fileHandlingCode1.Name = "fileHandlingCode1";
            this.fileHandlingCode1.Size = new System.Drawing.Size(1263, 885);
            this.fileHandlingCode1.TabIndex = 29;
            this.fileHandlingCode1.Visible = false;
            // 
            // FileHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 916);
            this.Controls.Add(this.fileHandlingCode1);
            this.Controls.Add(this.txbIntro4);
            this.Controls.Add(this.txbIntro2);
            this.Controls.Add(this.txbIntro1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileHandling";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Handling";
            this.Load += new System.EventHandler(this.FileHandling_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txbIntro4;
        private System.Windows.Forms.RichTextBox txbIntro2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txbIntro1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQuiz;
        private System.Windows.Forms.Button buttonTerms;
        private System.Windows.Forms.Button buttonIntro;
        private System.Windows.Forms.Panel panel2;
        private FileHandlingCode fileHandlingCode1;
    }
}