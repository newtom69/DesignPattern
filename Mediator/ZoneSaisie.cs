using System;

namespace Mediator
{
    public class ZoneSaisie : Controle
    {
        public ZoneSaisie(string nom) : base(nom) { }

        public override void saisie()
        {
            Console.WriteLine("Saisie de : " + Nom);
            Valeur = Console.ReadLine();
            Modifie();
        }
    }
}