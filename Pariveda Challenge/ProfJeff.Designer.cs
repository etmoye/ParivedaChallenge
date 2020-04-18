namespace Pariveda_Challenge
{
    partial class ProfJeff
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
            this.button1 = new System.Windows.Forms.Button();
            this.picJeff = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picJeff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "YOUR PROFESSOR IS JEFF LUCAS!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picJeff
            // 
            this.picJeff.Image = global::Pariveda_Challenge.Properties.Resources.jeff_lucas_pariveda;
            this.picJeff.Location = new System.Drawing.Point(280, 84);
            this.picJeff.Name = "picJeff";
            this.picJeff.Size = new System.Drawing.Size(226, 293);
            this.picJeff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picJeff.TabIndex = 4;
            this.picJeff.TabStop = false;
            this.picJeff.Click += new System.EventHandler(this.picJeff_Click);
            // 
            // ProfJeff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picJeff);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfJeff";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeff Lucas";
            ((System.ComponentModel.ISupportInitialize)(this.picJeff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picJeff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}