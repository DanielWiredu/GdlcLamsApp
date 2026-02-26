using AppModels.Service;
using Hangfire;
using MailKit.Net.Smtp;
using MimeKit;

namespace LAMS.Server.Services
{
    public class EmailServiceMailKit : IEmailService
    {
        private readonly IConfiguration _config;
        private readonly IBackgroundJobClient _jobClient;
        public EmailServiceMailKit(IConfiguration config, IBackgroundJobClient jobClient) 
        {
            _config = config;
            _jobClient = jobClient;
        }
        public void SendEmailAsync(EmailRequest request)
        {
            _jobClient.Enqueue(_config.GetSection("HangfireSettings:QueueName").Value, () => SendEmail(request));
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            _jobClient.Enqueue(_config.GetSection("HangfireSettings:QueueName").Value, () => SendEmail(new EmailRequest
            {
                To = email,
                Subject = subject,
                Body = message
            }));
        }
        public Task SendEmail(EmailRequest request)
        {
            var email = new MimeMessage();
            var senderName = _config.GetSection("EmailSettings:SenderName").Value;
            var senderEmail = _config.GetSection("EmailSettings:Username").Value;
            email.From.Add(new MailboxAddress(senderName, senderEmail));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;
            //email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = request.Body };

            // Create body parts
            var body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = request.Body };

            // Check for attachments
            MimeEntity messageBody;
            if (request.AttachmentFiles != null && request.AttachmentFiles.Any())
            {
                var multipart = new Multipart("mixed");
                multipart.Add(body);
                foreach (var filePath in request.AttachmentFiles)
                {
                    var attachment = new MimePart("application", "octet-stream")
                    {
                        Content = new MimeContent(File.OpenRead(filePath)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(filePath)
                    };
                    multipart.Add(attachment);
                }
                messageBody = multipart;
            }
            else
            {
                messageBody = body;
            }

            email.Body = messageBody;

            using var smtp = new SmtpClient();
            smtp.Connect(_config.GetSection("EmailSettings:Host").Value, 8889, MailKit.Security.SecureSocketOptions.Auto);
            smtp.Authenticate(_config.GetSection("EmailSettings:Username").Value, _config.GetSection("EmailSettings:Password").Value);
            smtp.Send(email);
            smtp.Disconnect(true);
            return Task.CompletedTask;
        }
    }
}
