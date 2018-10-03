using System;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rentrer le Prénom");
            string leprenom = Console.ReadLine();
            Console.WriteLine("Rentrer le Nom");
            string lenom = Console.ReadLine();
            Console.WriteLine("Rentrer l'age");
            int lage = Int32.Parse(Console.ReadLine());

            User user = new User();

            user.nom = lenom;
            user.prenom = leprenom;
            user.age = lage;

            Console.WriteLine($"prénom : {user.prenom}");
            Console.WriteLine($"nom : {user.nom}");
            Console.WriteLine($"age : {user.age}");
            Console.ReadLine();
        }
    }
}
