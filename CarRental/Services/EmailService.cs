using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

public class EmailService
{
    private readonly IConfiguration _config;

    public EmailService(IConfiguration config)
    {
        _config = config;
    }

    public async Task SendEmailAsync(string name, string email, string phone, string message)
    {
        var mailMessage = new MailMessage
        {
            From = new MailAddress(_config["EmailSettings:SenderEmail"]),
            Subject = "New Contact Form Submission",
            Body = $"Name: {name}\nEmail: {email}\nPhone: {phone}\nMessage:\n{message}",
            IsBodyHtml = false
        };

        mailMessage.To.Add(_config["EmailSettings:ReceiverEmail"]);

        using (var smtpClient = new SmtpClient(_config["EmailSettings:SMTPServer"], int.Parse(_config["EmailSettings:SMTPPort"])))
        {
            smtpClient.EnableSsl = false; // No authentication
            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
