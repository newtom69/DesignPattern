using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ServeurWeb serv = new ServeurWeb();
            serv.LoadAdapter();
            Console.ReadLine();
        }
    }
}
