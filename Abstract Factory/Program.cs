using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            Catalogue cat = new Catalogue();

            cat.LoadCatalogue();
            Console.ReadLine();

        }

    }
}
