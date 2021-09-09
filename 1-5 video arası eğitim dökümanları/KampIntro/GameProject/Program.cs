using System;

namespace GameProjectOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1995, FirstName = "RIDVAN", LastName = "ÜÇDAĞ", IdentityNumber = 123456 });
            Console.WriteLine("Hello World!");
        }
    }
}
