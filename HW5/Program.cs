using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                BirthYear=1995,
                FirstName="ÇAĞRI",
                LastName="ÇAMYAR",
                NationalityId="21593567558"
            }
            );
        }
    }
}