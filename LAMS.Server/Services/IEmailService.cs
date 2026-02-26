using AppModels.Service;

namespace LAMS.Server.Services
{
    public interface IEmailService
    {
        void SendEmailAsync(EmailRequest request);
        Task SendEmailAsync(string email, string subject, string message);
    }
}
