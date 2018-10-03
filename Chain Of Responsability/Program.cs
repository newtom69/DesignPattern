using ChainOfResponsibility;
using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilisateur util = new Utilisateur();
            util.LoadChainOfResponsibility();
            Console.ReadLine();
        }
    }
}
