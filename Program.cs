using System;
using bronzetti.christian._5h.PrimoEF.Models;
namespace bronzetti.christian._5h.PrimoEF
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello db-World!");

            // Apro il db
            DbPersone db = new();

            // Aggiungo una nuova persona
            for (int i = 0; i < 1000; i++)
            {
                db.Persone.Add(
                    new Persona {
                        Nome = "Christian", 
                        Cognome = "Bronzetti"
                    }
                );
            }

            db.SaveChanges();
        }
    }
}
