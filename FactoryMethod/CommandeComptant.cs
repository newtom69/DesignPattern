using System;
namespace FactoryMethod
{
    public class CommandeComptant : Commande
    {
        public CommandeComptant(double montant) : base(montant)
        { }

        public override void Paye()
        {
            Console.WriteLine("Le paiement de la commande au comptant de : " + _montant + " est effectué.");
        }
        public override void PayeKo()
        {
            Console.WriteLine("Le paiement de la commande au comptant de : " + _montant + " n'est pas effectué.");
        }

        public override bool Valide()
        {
            return (_montant <= 5000.0);
        }
    }
}