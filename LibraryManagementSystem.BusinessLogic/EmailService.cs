using MailKit.Net.Smtp;
using MimeKit;


namespace LibraryManagementSystem_Service
{

    public class EmailService
    {
        public void SendEmail(string bookNumber)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Library Transaction", "do-not-reply@library.com"));
            message.To.Add(new MailboxAddress("Account Owner", "user@example.com"));
            message.Subject = $"Book Update Notification";
            message.Body = new TextPart("plain")
            {
                Text = $"Book #{bookNumber} was updated successfully."
            };

            using (var client = new SmtpClient())
            {
                var smtpHost = "sandbox.smtp.mailtrap.io";
                var smtpPort = 2525;
                var tls = MailKit.Security.SecureSocketOptions.StartTls;
                client.Connect(smtpHost, smtpPort, tls);

                var userName = "8b0b41a73172a6"; 
                var password = "08803f8b7dc76d";

                client.Authenticate(userName, password);
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}


