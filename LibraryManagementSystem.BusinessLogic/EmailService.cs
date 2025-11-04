using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using LibraryCommon;


namespace LibraryManagementSystem_Service
{

    public class EmailService
    {
        private readonly IConfiguration _configuration;
        private readonly EmailSettings _settings;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;

            _settings = new EmailSettings();
            _configuration.GetSection("EmailSettings").Bind(_settings);
        }
        public void SendEmail(string bookNumber, string title, string recipientEmail)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_settings.FromName, _settings.FromEmail));
            message.To.Add(new MailboxAddress("Library User", recipientEmail));
            message.Subject = $"Book #{bookNumber} Updated";
            message.Body = new TextPart("plain")
            {
                Text = $"Book #{bookNumber} ({title}) was successfully updated."
            };

            using (var client = new SmtpClient())
            {

                client.Connect(_settings.SmtpHost, _settings.SmtpPort, SecureSocketOptions.StartTls);

                client.Authenticate(_settings.SmtpUsername, _settings.SmtpPassword);
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}


