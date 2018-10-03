using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilisateur util = new Utilisateur();
            util.LoadMediator();
            Console.ReadLine();
        }
    }
}
