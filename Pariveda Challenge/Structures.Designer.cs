namespace Pariveda_Challenge
{
    partial class Structures
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuiz = new System.Windows.Forms.Button();
            this.buttonTerms = new System.Windows.Forms.Button();
            this.buttonIntro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.repetitionStructure1 = new Pariveda_Challenge.RepetitionStructure();
            this.decisionStructure1 = new Pariveda_Challenge.DecisionStructure();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 55);
            this.label1.TabIndex = 24;
            this.label1.Text = "Decision and Repetition Structures";
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
            this.panel1.Size = new System.Drawing.Size(270, 885);
            this.panel1.TabIndex = 27;
            // 
            // buttonQuiz
            // 
            this.buttonQuiz.BackColor = System.Drawing.Color.Black;
            this.buttonQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonQuiz.ForeColor = System.Drawing.Color.White;
            this.buttonQuiz.Location = new System.Drawing.Point(51, 283);
            this.buttonQuiz.Name = "buttonQuiz";
            this.buttonQuiz.Size = new System.Drawing.Size(234, 64);
            this.buttonQuiz.TabIndex = 13;
            this.buttonQuiz.Text = "Quiz";
            this.buttonQuiz.UseVisualStyleBackColor = false;
            this.buttonQuiz.Click += new System.EventHandler(this.buttonQuiz_Click);
            // 
            // buttonTerms
            // 
            this.buttonTerms.BackColor = System.Drawing.Color.Black;
            this.buttonTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonTerms.ForeColor = System.Drawing.Color.White;
            this.buttonTerms.Location = new System.Drawing.Point(51, 191);
            this.buttonTerms.Name = "buttonTerms";
            this.buttonTerms.Size = new System.Drawing.Size(234, 64);
            this.buttonTerms.TabIndex = 14;
            this.buttonTerms.Text = "Repetition Structures";
            this.buttonTerms.UseVisualStyleBackColor = false;
            this.buttonTerms.Click += new System.EventHandler(this.buttonTerms_Click);
            // 
            // buttonIntro
            // 
            this.buttonIntro.BackColor = System.Drawing.Color.Black;
            this.buttonIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonIntro.ForeColor = System.Drawing.Color.White;
            this.buttonIntro.Location = new System.Drawing.Point(51, 94);
            this.buttonIntro.Name = "buttonIntro";
            this.buttonIntro.Size = new System.Drawing.Size(234, 64);
            this.buttonIntro.TabIndex = 11;
            this.buttonIntro.Text = "Decision Stuctures";
            this.buttonIntro.UseVisualStyleBackColor = false;
            this.buttonIntro.Click += new System.EventHandler(this.buttonIntro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1515, 123);
            this.panel2.TabIndex = 28;
            // 
            // repetitionStructure1
            // 
            this.repetitionStructure1.Location = new System.Drawing.Point(276, 123);
            this.repetitionStructure1.Name = "repetitionStructure1";
            this.repetitionStructure1.Size = new System.Drawing.Size(1263, 885);
            this.repetitionStructure1.TabIndex = 30;
            // 
            // decisionStructure1
            // 
            this.decisionStructure1.Location = new System.Drawing.Point(276, 123);
            this.decisionStructure1.Name = "decisionStructure1";
            this.decisionStructure1.Size = new System.Drawing.Size(1263, 885);
            this.decisionStructure1.TabIndex = 29;
            // 
            // Structures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 1008);
            this.Controls.Add(this.repetitionStructure1);
            this.Controls.Add(this.decisionStructure1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Structures";
            this.ShowIcon = false;
            this.Text = "Stuctures";
            this.Load += new System.EventHandler(this.Structures_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQuiz;
        private System.Windows.Forms.Button buttonTerms;
        private System.Windows.Forms.Button buttonIntro;
        private System.Windows.Forms.Panel panel2;
        private DecisionStructure decisionStructure1;
        private RepetitionStructure repetitionStructure1;
    }
}