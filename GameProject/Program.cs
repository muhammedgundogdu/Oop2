using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirtYear = 1999,
                FirstName = "Muhammed",
                LastName = "Gündoğdu",
                IdentityNumber = 12345
            });
           
        }
    }
}
