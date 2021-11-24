// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLID;
internal class UserServiceNotSolid
{
    internal void Register(string email, string password)
    {
        if (!IsValidEmail(email))
        {
            throw new ValidationException($"{email} is not a valid email address");
        }

        string encryptedPassword = EncryptPassword(password);
        User user = new() { Email = email, Password = encryptedPassword };

        SaveUserToDatabase(user);
        AddUserToCache(user);
        SendEmail(new MailMessage("admin@ciber.com", email) { Subject = "Welcome to Olympus!" });
    }

    private void AddUserToCache(User user)
    {
        Console.WriteLine($"Great logic to add a user with email {user.Email} to cache");
    }

    private void SendEmail(MailMessage mailMessage)
    {
        Console.WriteLine($"Great logic to send email - Email sent to {mailMessage.To.First().Address}");
    }

    private void SaveUserToDatabase(User user)
    {
        Console.WriteLine($"Great logic to save the user to DB - User  with email {user.Email} was saved.");
    }

    private string EncryptPassword(string password)
    {
        var passwordArray = password.ToArray();
        Array.Reverse(passwordArray);
        var encryptedPassword = new string(passwordArray);
        Console.WriteLine($"Great logic to encrypt password. The new password is {encryptedPassword}");
        return encryptedPassword;
    }

    private bool IsValidEmail(string email)
    {
        Console.WriteLine("Great logic to valid the email");
        return !string.IsNullOrWhiteSpace(email) && email.Contains("@");
    }
}