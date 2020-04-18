namespace Pariveda_Challenge
{
    partial class Crowe
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
            this.webBrowserCrowe = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserCrowe
            // 
            this.webBrowserCrowe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserCrowe.Location = new System.Drawing.Point(0, 0);
            this.webBrowserCrowe.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserCrowe.Name = "webBrowserCrowe";
            this.webBrowserCrowe.Size = new System.Drawing.Size(1411, 894);
            this.webBrowserCrowe.TabIndex = 0;
            this.webBrowserCrowe.Url = new System.Uri("https://www.crowe.com/", System.UriKind.Absolute);
            // 
            // Crowe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 894);
            this.Controls.Add(this.webBrowserCrowe);
            this.MinimizeBox = false;
            this.Name = "Crowe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crowe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserCrowe;
    }
}