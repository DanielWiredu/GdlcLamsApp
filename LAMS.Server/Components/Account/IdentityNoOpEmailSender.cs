using LAMS.Server.Data;
using LAMS.Server.Services;
using Microsoft.AspNetCore.Identity;

namespace LAMS.Server.Components.Account
{
    // Remove the "else if (EmailSender is IdentityNoOpEmailSender)" block from RegisterConfirmation.razor after updating with a real implementation.
  internal sealed class IdentityNoOpEmailSender : IEmailSender<ApplicationUser>
{
    private readonly IEmailService _emailService;

    public IdentityNoOpEmailSender(IEmailService emailService)
    {
        _emailService = emailService;
    }
    public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink)
    {
        var subject = "Confirm your email";
        var body = $"Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.";
        return _emailService.SendEmailAsync(email, subject, body);
    }

    public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink)
    {
        var subject = "Reset your password";
        var body = $"Please reset your password by <a href='{resetLink}'>clicking here</a>.";
        return _emailService.SendEmailAsync(email, subject, body);
    }

    public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode)
    {
        var subject = "Reset your password";
        var body = $"Please reset your password using the following code: {resetCode}";
        return _emailService.SendEmailAsync(email, subject, body);
    }
}
}
