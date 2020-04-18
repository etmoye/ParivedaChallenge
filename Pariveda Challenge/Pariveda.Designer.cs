namespace Pariveda_Challenge
{
    partial class Pariveda
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
            this.ParivedaSolutions = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // ParivedaSolutions
            // 
            this.ParivedaSolutions.AccessibleName = "";
            this.ParivedaSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParivedaSolutions.Location = new System.Drawing.Point(0, 0);
            this.ParivedaSolutions.MinimumSize = new System.Drawing.Size(20, 20);
            this.ParivedaSolutions.Name = "ParivedaSolutions";
            this.ParivedaSolutions.Size = new System.Drawing.Size(1398, 886);
            this.ParivedaSolutions.TabIndex = 0;
            this.ParivedaSolutions.Url = new System.Uri("https://www.parivedasolutions.com/", System.UriKind.Absolute);
            // 
            // Pariveda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 886);
            this.Controls.Add(this.ParivedaSolutions);
            this.MinimizeBox = false;
            this.Name = "Pariveda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pariveda Solutions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser ParivedaSolutions;
    }
}