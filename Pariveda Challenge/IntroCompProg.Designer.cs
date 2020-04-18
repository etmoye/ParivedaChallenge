namespace Pariveda_Challenge
{
    partial class IntroCompProg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroCompProg));
            this.txbIntro4 = new System.Windows.Forms.RichTextBox();
            this.txbIntro2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTerms = new System.Windows.Forms.Button();
            this.buttonQuiz = new System.Windows.Forms.Button();
            this.txbIntro1 = new System.Windows.Forms.RichTextBox();
            this.buttonIntro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbIntro4
            // 
            this.txbIntro4.BackColor = System.Drawing.SystemColors.Control;
            this.txbIntro4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIntro4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIntro4.Location = new System.Drawing.Point(308, 519);
            this.txbIntro4.Name = "txbIntro4";
            this.txbIntro4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbIntro4.Size = new System.Drawing.Size(1070, 137);
            this.txbIntro4.TabIndex = 19;
            this.txbIntro4.Text = resources.GetString("txbIntro4.Text");
            // 
            // txbIntro2
            // 
            this.txbIntro2.BackColor = System.Drawing.SystemColors.Control;
            this.txbIntro2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIntro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbIntro2.Location = new System.Drawing.Point(308, 373);
            this.txbIntro2.Name = "txbIntro2";
            this.txbIntro2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbIntro2.Size = new System.Drawing.Size(1070, 105);
            this.txbIntro2.TabIndex = 17;
            this.txbIntro2.Text = resources.GetString("txbIntro2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 55);
            this.label1.TabIndex = 16;
            this.label1.Text = "Computers and Programming\r\n";
            // 
            // buttonTerms
            // 
            this.buttonTerms.BackColor = System.Drawing.Color.Black;
            this.buttonTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonTerms.ForeColor = System.Drawing.Color.White;
            this.buttonTerms.Location = new System.Drawing.Point(77, 191);
            this.buttonTerms.Name = "buttonTerms";
            this.buttonTerms.Size = new System.Drawing.Size(208, 64);
            this.buttonTerms.TabIndex = 14;
            this.buttonTerms.Text = "Terminology";
            this.buttonTerms.UseVisualStyleBackColor = false;
            this.buttonTerms.Click += new System.EventHandler(this.buttonTerms_Click);
            // 
            // buttonQuiz
            // 
            this.buttonQuiz.BackColor = System.Drawing.Color.Black;
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
            // txbIntro1
            // 
            this.txbIntro1.BackColor = System.Drawing.SystemColors.Control;
            this.txbIntro1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIntro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbIntro1.Location = new System.Drawing.Point(308, 165);
            this.txbIntro1.Name = "txbIntro1";
            this.txbIntro1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbIntro1.Size = new System.Drawing.Size(1070, 164);
            this.txbIntro1.TabIndex = 12;
            this.txbIntro1.Text = resources.GetString("txbIntro1.Text");
            // 
            // buttonIntro
            // 
            this.buttonIntro.BackColor = System.Drawing.Color.Black;
            this.buttonIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonIntro.ForeColor = System.Drawing.Color.White;
            this.buttonIntro.Location = new System.Drawing.Point(77, 94);
            this.buttonIntro.Name = "buttonIntro";
            this.buttonIntro.Size = new System.Drawing.Size(208, 64);
            this.buttonIntro.TabIndex = 11;
            this.buttonIntro.Text = "Intro";
            this.buttonIntro.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonQuiz);
            this.panel1.Controls.Add(this.buttonTerms);
            this.panel1.Controls.Add(this.buttonIntro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 793);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1457, 123);
            this.panel2.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(308, 689);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(1070, 137);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // IntroCompProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 916);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txbIntro4);
            this.Controls.Add(this.txbIntro2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbIntro1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroCompProg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduction to Computers and Programming";
            this.Load += new System.EventHandler(this.IntroCompProg_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbIntro4;
        private System.Windows.Forms.RichTextBox txbIntro2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTerms;
        private System.Windows.Forms.Button buttonQuiz;
        private System.Windows.Forms.RichTextBox txbIntro1;
        private System.Windows.Forms.Button buttonIntro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}