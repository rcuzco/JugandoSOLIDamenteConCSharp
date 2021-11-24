// See https://aka.ms/new-console-template for more information

namespace SOLID
{
    internal class UserRespositoryService
    {
        internal void SaveUserToDatabase(User user)
        {
            Console.WriteLine($"Great logic to save the user to DB - User  with email {user.Email} was saved.");
        }
    }
}