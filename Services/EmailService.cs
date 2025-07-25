using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Maui.Storage;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLogBook.Services
{
    public class EmailService
    {
        public async Task SendEmailAsync(string fromEmail, string subject, string body, string ToEmailAdd, int Port, string AppPwd, string MailServer, bool EmailAuth, bool SSL, IDictionary<string, string> CSVData )
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(fromEmail.ToLower()));
            //email.To.Add(MailboxAddress.Parse("rosuthecoder48@gmail.com"));
            //email.To.Add(MailboxAddress.Parse("amish@jupitersystems.in"));
            email.To.Add(MailboxAddress.Parse(ToEmailAdd.ToLower()));
            email.Subject = subject;
            // Create body parts
            var builder = new BodyBuilder
            {
                HtmlBody = body
            };

            // Add attachment
            foreach(var data in CSVData)
            {
                var bytes = Encoding.UTF8.GetBytes(data.Value);
                var stream = new MemoryStream(bytes);
                builder.Attachments.Add(data.Key+".csv", stream, new ContentType("text", "csv"));
            }
            // Add in-memory attachment
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            //await smtp.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            await smtp.ConnectAsync(MailServer, Port, SSL);
            if (EmailAuth)
            {
                //await smtp.AuthenticateAsync(fromEmail, "fqkw qdtt prej reok"); // App Password
                await smtp.AuthenticateAsync(fromEmail, AppPwd); // App Password
            }
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}
