using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Pariveda_Challenge
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        //DO NOT USE - RAN INTO SECURITY ERRORS ACCESSING A GOOGLE ACCOUNT

        private void Email_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {

                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = 587;
                clientDetails.Host = textBoxSmtpServer.Text.Trim();
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(textBoxSenderEmail.Text.Trim(), textBoxSenderPassword.Text.Trim());
               // clientDetails.Send();

                //message details
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(textBoxSenderEmail.Text.Trim());
                mailDetails.To.Add(textBoxRecipEmail.Text.Trim());
                mailDetails.Subject = textBoxSubject.Text.Trim();
                mailDetails.IsBodyHtml = checkBoxHTML.Checked;
                mailDetails.Body = richTextBoxBody.Text.Trim();
                clientDetails.Send(mailDetails);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
