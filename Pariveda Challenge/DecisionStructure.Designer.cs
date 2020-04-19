namespace Pariveda_Challenge
{
    partial class DecisionStructure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecisionStructure));
            this.txbDecision5 = new System.Windows.Forms.RichTextBox();
            this.txbDecision4 = new System.Windows.Forms.RichTextBox();
            this.txbDecision3 = new System.Windows.Forms.RichTextBox();
            this.txbDecision2 = new System.Windows.Forms.RichTextBox();
            this.txbDecision1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txbDecision5
            // 
            this.txbDecision5.BackColor = System.Drawing.SystemColors.Control;
            this.txbDecision5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDecision5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDecision5.Location = new System.Drawing.Point(393, 561);
            this.txbDecision5.Name = "txbDecision5";
            this.txbDecision5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbDecision5.Size = new System.Drawing.Size(680, 258);
            this.txbDecision5.TabIndex = 35;
            this.txbDecision5.Text = "Example:\nif(num1 == num2)\n{\n    Console.WriteLine(\"These numbers are equal\");\n}\ne" +
    "lse\n{\n      Console.WriteLine(\"The numbers are not equal\");\n}";
            // 
            // txbDecision4
            // 
            this.txbDecision4.BackColor = System.Drawing.SystemColors.Control;
            this.txbDecision4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDecision4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDecision4.Location = new System.Drawing.Point(393, 435);
            this.txbDecision4.Name = "txbDecision4";
            this.txbDecision4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbDecision4.Size = new System.Drawing.Size(701, 99);
            this.txbDecision4.TabIndex = 34;
            this.txbDecision4.Text = "Logical Operators:\n&& if the condition on the left AND right are met, process wil" +
    "l execute\n  | |  if the condition on the left OR right are met, process will exe" +
    "cute\n\n";
            // 
            // txbDecision3
            // 
            this.txbDecision3.BackColor = System.Drawing.SystemColors.Control;
            this.txbDecision3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDecision3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDecision3.Location = new System.Drawing.Point(24, 435);
            this.txbDecision3.Name = "txbDecision3";
            this.txbDecision3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbDecision3.Size = new System.Drawing.Size(284, 237);
            this.txbDecision3.TabIndex = 33;
            this.txbDecision3.Text = "Relational operators:\n>   greater than\n<   less than\n>= greater than or equal to\n" +
    "<= less than or equal to\n== equal to\n!=   not equal to\n\n";
            // 
            // txbDecision2
            // 
            this.txbDecision2.BackColor = System.Drawing.SystemColors.Control;
            this.txbDecision2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDecision2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbDecision2.Location = new System.Drawing.Point(24, 190);
            this.txbDecision2.Name = "txbDecision2";
            this.txbDecision2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbDecision2.Size = new System.Drawing.Size(1170, 213);
            this.txbDecision2.TabIndex = 32;
            this.txbDecision2.Text = resources.GetString("txbDecision2.Text");
            // 
            // txbDecision1
            // 
            this.txbDecision1.BackColor = System.Drawing.SystemColors.Control;
            this.txbDecision1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDecision1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbDecision1.Location = new System.Drawing.Point(24, 20);
            this.txbDecision1.Name = "txbDecision1";
            this.txbDecision1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbDecision1.Size = new System.Drawing.Size(1170, 164);
            this.txbDecision1.TabIndex = 31;
            this.txbDecision1.Text = resources.GetString("txbDecision1.Text");
            // 
            // DecisionStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbDecision5);
            this.Controls.Add(this.txbDecision4);
            this.Controls.Add(this.txbDecision3);
            this.Controls.Add(this.txbDecision2);
            this.Controls.Add(this.txbDecision1);
            this.Name = "DecisionStructure";
            this.Size = new System.Drawing.Size(1263, 834);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbDecision5;
        private System.Windows.Forms.RichTextBox txbDecision4;
        private System.Windows.Forms.RichTextBox txbDecision3;
        private System.Windows.Forms.RichTextBox txbDecision2;
        private System.Windows.Forms.RichTextBox txbDecision1;
    }
}
