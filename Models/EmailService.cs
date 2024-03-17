using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace WebApplication1.Models
{
    public class EmailService
    {
        public void SendEmail(string mailTo, string mailFrom, string mailReply, string subject, string body)
        {
            try
            {
                MailMessage message = new MailMessage(mailFrom, mailTo);
                message.ReplyToList.Add(mailReply);
                message.Subject = subject;
                message.Body = body;
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("an0932003860@gmail.com", "jhddgheiqkretsni");

                client.Send(message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}