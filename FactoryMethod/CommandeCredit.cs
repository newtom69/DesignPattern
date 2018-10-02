using System;

namespace FactoryMethod
{
    public class CommandeCredit : Commande
    {
        public CommandeCredit(double montant) : base(montant)
        { }

        public override void Paye()
        {
            Console.WriteLine("Le paiement de la commande au cr�dit de : " + _montant + " est effectu�.");
        }
        public override void PayeKo()
        {
            Console.WriteLine("Le paiement de la commande au cr�dit de : " + _montant + " n'est pas effectu�.");
        }

        public override bool Valide()
        {
            return (_montant >= 1000.0);
        }
    }
}