using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class Client
    {
        protected IList<Commande> _commandes = new List<Commande>();

        protected abstract Commande CreerCommande(double montant);

        public void NouvelleCommande(double montant)
        {
            Commande commande = this.CreerCommande(montant);
            if (commande.Valide())
            {
                commande.Paye();
                _commandes.Add(commande);
            }
            else
            {
                commande.PayeKo();
            }
        }
    }
}