using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SMTPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMessage("r-9@gmail.com", "Hello World!");
        }
        public static void SendMessage(string _subject, string _message)
        {
            SmtpClient _smtp = new SmtpClient("smtp.gmail.com", 587);

            _smtp.Credentials = new NetworkCredential("username", "password");

            _smtp.EnableSsl = true;

            MailMessage _mail = new MailMessage();

            _mail.From = new MailAddress("mail");

            _mail.To.Add(new MailAddress("mail"));

            _mail.SubjectEncoding = Encoding.UTF8;

            _mail.BodyEncoding = Encoding.UTF8;

            _mail.Subject = _subject;

            _mail.Body = _message;

            try
            {
                _smtp.Send(_mail);
                Console.WriteLine("Done!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
