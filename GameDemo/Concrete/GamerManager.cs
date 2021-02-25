using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    // Microservice
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Saved gamer");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted gamer");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated gamer");
        }
    }
}
