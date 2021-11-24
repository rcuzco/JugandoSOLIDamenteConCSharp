// See https://aka.ms/new-console-template for more information

namespace SOLID
{
    internal class CacheService
    {
        internal void AddUserToCache(User user)
        {
            Console.WriteLine($"Great logic to add a user with email {user.Email} to cache");
        }
    }
}