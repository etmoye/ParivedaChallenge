namespace Pariveda_Challenge
{
    partial class RepetitionStructure
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepetitionStructure));
            this.txbDecision5 = new System.Windows.Forms.RichTextBox();
            this.txbDecision2 = new System.Windows.Forms.RichTextBox();
            this.txbDecision1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txbDecision5
            // 
            this.txbDecision5.BackColor = System.Drawing.SystemColors.Control;
            this.txbDecision5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDecision5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDecision5.Location = new System.Drawing.Point(603, 490);
            this.txbDecision5.Name = "txbDecision5";
            this.txbDecision5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbDecision5.Size = new System.Drawing.Size(627, 341);
            this.txbDecision5.TabIndex = 40;
            this.txbDecision5.Text = resources.GetString("txbDecision5.Text");
            // 
            // txbDecision2
            // 
            this.txbDecision2.BackColor = System.Drawing.SystemColors.Control;
            this.txbDecision2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDecision2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbDecision2.Location = new System.Drawing.Point(28, 221);
            this.txbDecision2.Name = "txbDecision2";
            this.txbDecision2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbDecision2.Size = new System.Drawing.Size(1170, 213);
            this.txbDecision2.TabIndex = 37;
            this.txbDecision2.Text = resources.GetString("txbDecision2.Text");
            // 
            // txbDecision1
            // 
            this.txbDecision1.BackColor = System.Drawing.SystemColors.Control;
            this.txbDecision1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDecision1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbDecision1.Location = new System.Drawing.Point(28, 25);
            this.txbDecision1.Name = "txbDecision1";
            this.txbDecision1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbDecision1.Size = new System.Drawing.Size(1170, 164);
            this.txbDecision1.TabIndex = 36;
            this.txbDecision1.Text = resources.GetString("txbDecision1.Text");
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(28, 490);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(546, 294);
            this.richTextBox1.TabIndex = 41;
            this.richTextBox1.Text = "WHILE LOOP - Condition Controlled\n\nint x = 10;\nwhile(x < 15) \n{\n       Console.Wr" +
    "iteLine(x);\n        x+2;\n}\nConsoleWriteLine(\"The final value of x is \" + x);\n//f" +
    "inal value of x will equal 14";
            // 
            // RepetitionStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txbDecision5);
            this.Controls.Add(this.txbDecision2);
            this.Controls.Add(this.txbDecision1);
            this.Name = "RepetitionStructure";
            this.Size = new System.Drawing.Size(1263, 834);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbDecision5;
        private System.Windows.Forms.RichTextBox txbDecision2;
        private System.Windows.Forms.RichTextBox txbDecision1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
