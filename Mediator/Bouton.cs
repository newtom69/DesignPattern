using System;

namespace Mediator
{
    public class Bouton : Controle
    {
        public Bouton(string nom) : base(nom) { }

        public override void saisie()
        {
            Console.WriteLine($"D�sirez-vous activer le bouton {Nom} ?");
            string reponse = Console.ReadLine();
            if (reponse == "oui")
                Modifie();
        }
    }
}