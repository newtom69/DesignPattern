using System;

namespace FactoryMethod
{
    public class CommandeCredit : Commande
    {
        public CommandeCredit(double montant) : base(montant)
        { }

        public override void Paye()
        {
            Console.WriteLine("Le paiement de la commande au crédit de : " + _montant + " est effectué.");
        }
        public override void PayeKo()
        {
            Console.WriteLine("Le paiement de la commande au crédit de : " + _montant + " n'est pas effectué.");
        }

        public override bool Valide()
        {
            return (_montant >= 1000.0);
        }
    }
}