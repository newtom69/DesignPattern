using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilisateur util = new Utilisateur();
            util.LoadBridge();
            Console.ReadLine();
        }
    }
}
