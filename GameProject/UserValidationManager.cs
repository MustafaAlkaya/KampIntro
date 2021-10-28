using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirstName == "Mustafa" && gamer.LastName=="Alkaya" && gamer.IdentityNumber==51499233523)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
