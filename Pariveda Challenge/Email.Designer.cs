namespace Pariveda_Challenge
{
    partial class Email
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSenderEmail = new System.Windows.Forms.TextBox();
            this.textBoxSenderPassword = new System.Windows.Forms.TextBox();
            this.textBoxSmtpServer = new System.Windows.Forms.TextBox();
            this.textBoxPortNumber = new System.Windows.Forms.TextBox();
            this.textBoxRecipEmail = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.checkBoxSSL = new System.Windows.Forms.CheckBox();
            this.checkBoxHTML = new System.Windows.Forms.CheckBox();
            this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "sender email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "sender password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "smtp server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "port number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "recipient email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "subject\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "body";
            // 
            // textBoxSenderEmail
            // 
            this.textBoxSenderEmail.Location = new System.Drawing.Point(242, 69);
            this.textBoxSenderEmail.Name = "textBoxSenderEmail";
            this.textBoxSenderEmail.Size = new System.Drawing.Size(220, 26);
            this.textBoxSenderEmail.TabIndex = 7;
            // 
            // textBoxSenderPassword
            // 
            this.textBoxSenderPassword.Location = new System.Drawing.Point(242, 122);
            this.textBoxSenderPassword.Name = "textBoxSenderPassword";
            this.textBoxSenderPassword.Size = new System.Drawing.Size(220, 26);
            this.textBoxSenderPassword.TabIndex = 8;
            // 
            // textBoxSmtpServer
            // 
            this.textBoxSmtpServer.Location = new System.Drawing.Point(242, 186);
            this.textBoxSmtpServer.Name = "textBoxSmtpServer";
            this.textBoxSmtpServer.Size = new System.Drawing.Size(220, 26);
            this.textBoxSmtpServer.TabIndex = 9;
            // 
            // textBoxPortNumber
            // 
            this.textBoxPortNumber.Location = new System.Drawing.Point(242, 244);
            this.textBoxPortNumber.Name = "textBoxPortNumber";
            this.textBoxPortNumber.Size = new System.Drawing.Size(220, 26);
            this.textBoxPortNumber.TabIndex = 10;
            // 
            // textBoxRecipEmail
            // 
            this.textBoxRecipEmail.Location = new System.Drawing.Point(242, 309);
            this.textBoxRecipEmail.Name = "textBoxRecipEmail";
            this.textBoxRecipEmail.Size = new System.Drawing.Size(220, 26);
            this.textBoxRecipEmail.TabIndex = 11;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(242, 380);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(220, 26);
            this.textBoxSubject.TabIndex = 12;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(703, 540);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(140, 64);
            this.buttonSend.TabIndex = 14;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // checkBoxSSL
            // 
            this.checkBoxSSL.AutoSize = true;
            this.checkBoxSSL.Location = new System.Drawing.Point(533, 188);
            this.checkBoxSSL.Name = "checkBoxSSL";
            this.checkBoxSSL.Size = new System.Drawing.Size(66, 24);
            this.checkBoxSSL.TabIndex = 15;
            this.checkBoxSSL.Text = "SSL";
            this.checkBoxSSL.UseVisualStyleBackColor = true;
            // 
            // checkBoxHTML
            // 
            this.checkBoxHTML.AutoSize = true;
            this.checkBoxHTML.Location = new System.Drawing.Point(533, 445);
            this.checkBoxHTML.Name = "checkBoxHTML";
            this.checkBoxHTML.Size = new System.Drawing.Size(78, 24);
            this.checkBoxHTML.TabIndex = 16;
            this.checkBoxHTML.Text = "HTML";
            this.checkBoxHTML.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBody
            // 
            this.richTextBoxBody.Location = new System.Drawing.Point(251, 449);
            this.richTextBoxBody.Name = "richTextBoxBody";
            this.richTextBoxBody.Size = new System.Drawing.Size(224, 155);
            this.richTextBoxBody.TabIndex = 17;
            this.richTextBoxBody.Text = "";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 697);
            this.Controls.Add(this.richTextBoxBody);
            this.Controls.Add(this.checkBoxHTML);
            this.Controls.Add(this.checkBoxSSL);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxRecipEmail);
            this.Controls.Add(this.textBoxPortNumber);
            this.Controls.Add(this.textBoxSmtpServer);
            this.Controls.Add(this.textBoxSenderPassword);
            this.Controls.Add(this.textBoxSenderEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Email";
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSenderEmail;
        private System.Windows.Forms.TextBox textBoxSenderPassword;
        private System.Windows.Forms.TextBox textBoxSmtpServer;
        private System.Windows.Forms.TextBox textBoxPortNumber;
        private System.Windows.Forms.TextBox textBoxRecipEmail;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.CheckBox checkBoxSSL;
        private System.Windows.Forms.CheckBox checkBoxHTML;
        private System.Windows.Forms.RichTextBox richTextBoxBody;
    }
}