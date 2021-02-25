using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
