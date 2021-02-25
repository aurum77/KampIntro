using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                YearOfBirth = 2001,
                FirstName = "Engin",
                LastName = "Demirog",
                IdentityNumber = 123435444
            });
        }
    }
}
