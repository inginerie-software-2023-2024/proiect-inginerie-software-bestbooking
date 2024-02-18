using MailKit.Net.Smtp;
using MailKit.Security;
using MDS.Models;
using MimeKit;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MDS.Controllers
{
    public class EmailService
    {
        public async Task SendReservationDetailsAsync(string userEmail, string subject, Rezervare rez)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Your Name", "jarret.doyle@ethereal.email"));
            message.To.Add(new MailboxAddress("", userEmail)); // Adresa de e-mail a utilizatorului
            message.Subject = subject;

            message.Body = new TextPart("plain")
            {
                Text = rez.ListaClienti
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                await client.ConnectAsync("smtp.ethereal.email", 587, SecureSocketOptions.StartTls); // Adresa SMTP și portul
                await client.AuthenticateAsync("jarret.doyle@ethereal.email", "Uw8rtWpRSVghemBzY6"); // Autentificare SMTP
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}

