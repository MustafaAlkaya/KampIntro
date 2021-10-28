using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            { BirthYear = 1999, Id = 1, FirstName = "Mustafa", LastName = "Alkaya", IdentityNumber = 554755568 });
        }
    }
}
