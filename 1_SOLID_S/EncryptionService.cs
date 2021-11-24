// See https://aka.ms/new-console-template for more information

namespace SOLID
{
    internal class EncryptionService
    {
        internal string EncryptPassword(string password)
        {
            var passwordArray = password.ToArray();
            Array.Reverse(passwordArray);
            var encryptedPassword = new string(passwordArray);
            Console.WriteLine($"Great logic to encrypt password. The new password is {encryptedPassword}");
            return encryptedPassword;
        }
    }
}