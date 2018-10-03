using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilisateur util = new Utilisateur();
            util.LoadMemento();
            Console.ReadLine();
        }
    }
}
