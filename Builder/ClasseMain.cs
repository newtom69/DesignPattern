using System;

namespace Builder
{
    class ClasseMain
    {
        static void Main(string[] args)
        {

            ClientVehicule clientVehicule = new ClientVehicule();
            clientVehicule.LoadBuilder();
            Console.ReadLine();
        }

    }
}
