using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sending_EXP.Util
{
    public class Helper
    {
        public void emailgenartaion(string toEmailAddress,string subject,string body)
        {
            //logic of email sending
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("codeaffections@gmail.com");

                mail.To.Add(toEmailAddress);
                mail.Subject = subject;
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("codeaffections@gmail.com", "P@$$W0RD");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("Email Sent");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
