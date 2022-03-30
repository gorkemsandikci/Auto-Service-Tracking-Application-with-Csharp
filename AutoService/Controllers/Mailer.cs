using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Controllers
{
    public class Mailer
    {
        public static bool MailGonder(string alici, string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("gorkem@gorkemnet.com");
            ePosta.To.Add(alici); //göndereceğimiz mail adresi
            ePosta.Subject = konu; //mail konusu
            ePosta.Body = icerik; //mail içeriği 

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("gorkem@gorkemnet.com", "1309110052Gs?");
            client.Port = 25;
            client.Host = "mail.gorkemnet.com";
            client.EnableSsl = false;
            client.Send(ePosta);
            object userState = true;
            bool kontrol = true;
            return kontrol;
        }
    }
}
