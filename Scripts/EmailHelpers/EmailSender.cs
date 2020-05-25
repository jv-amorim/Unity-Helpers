using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace UnityHelpers.EmailHelpers
{
    public static class EmailSender
    {
        public static async Task<bool> SendEmailMessage(EmailMessage emailMessage)
        {
            try
            {
                NetworkCredential credentials =
                    CreateNetworkCredential(emailMessage.SenderEmailAddress, emailMessage.SenderPassword);
                MailMessage message =
                    CreateMailMessage(emailMessage.RecepientEmailAddress, emailMessage.Subject,
                    emailMessage.MessageBody, emailMessage.IsBodyHtml);

                SmtpClient emailSender = new SmtpClient(emailMessage.Host, emailMessage.Port)
                {
                    UseDefaultCredentials = false,
                    Credentials = credentials,
                    EnableSsl = true
                };

                await emailSender.SendMailAsync(message);

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        
        private static NetworkCredential CreateNetworkCredential(string email, string password) => new NetworkCredential(email, password);
        
        private static MailMessage CreateMailMessage(string email, string subject, string messageBody, bool isBodyHtml)
        {
            MailMessage message = new MailMessage
            {
                From = new MailAddress(email),
                Subject = subject,
                Body = messageBody,
                IsBodyHtml = isBodyHtml
            };
            message.To.Add(email);

            return message;
        }
    }
}