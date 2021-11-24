// See https://aka.ms/new-console-template for more information

using System.Net.Mail;

namespace SOLID
{
    internal class EmailService
    {
        internal void SendEmail(MailMessage mailMessage)
        {
            Console.WriteLine($"Great logic to send email - Email sent to {mailMessage.To.First().Address}");
        }

        internal bool IsValidEmail(string email)
        {
            Console.WriteLine("Great logic to valid the email");
            return !string.IsNullOrWhiteSpace(email) && email.Contains("@");
        }
    }    
}