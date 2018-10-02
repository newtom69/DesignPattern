
namespace FactoryMethod
{
    public class ClientComptant : Client
    {
        protected override Commande CreerCommande(double montant)
        {
            return new CommandeComptant(montant);
        }
    }
}