using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TestVendeur test = new TestVendeur();
            test.LoadSingleton();
            Console.ReadLine();
        }
    }
}
