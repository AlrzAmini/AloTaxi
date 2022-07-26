using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AloTaxi.Application.Utilities.Senders
{
    public static class EmailSender
    {
        public static async Task Send(string to, string subject, string body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.mail.yahoo.com");
            mail.From = new MailAddress("dahakdolatabad@yahoo.com", "الو تاکسی | Alo Taxi");
            mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("dahakdolatabad@yahoo.com", "dbfjlckbrfrbfsyw");
            smtpServer.EnableSsl = true;

            await Task.Run(() =>
            {
                smtpServer.SendAsync(mail, null);
            });
        }
    }
}
