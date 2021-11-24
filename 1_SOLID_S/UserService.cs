// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLID;
internal class UserService
{
    private readonly EmailService _emailService;
    private readonly EncryptionService _encryptionService;
    private readonly UserRespositoryService _userRespositoryService;
    private readonly CacheService _cacheService;

    public UserService(EmailService emailService, EncryptionService encryptionService, UserRespositoryService userRespositoryService, CacheService cacheService)
    {
        _emailService = emailService;
        _encryptionService = encryptionService;
        _userRespositoryService = userRespositoryService;
        _cacheService = cacheService;
    }

    internal void Register(string email, string password)
    {
        if (!_emailService.IsValidEmail(email))
        {
            throw new ValidationException($"{email} is not a valid email address");
        }

        string encryptedPassword = _encryptionService.EncryptPassword(password);
        User user = new() { Email = email, Password = encryptedPassword };

        _userRespositoryService.SaveUserToDatabase(user);
        _cacheService.AddUserToCache(user);
        _emailService.SendEmail(new MailMessage("admin@ciber.com", email) { Subject = "Welcome to Olympus!" });
    }
}