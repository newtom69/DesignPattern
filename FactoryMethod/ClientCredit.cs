namespace FactoryMethod
{
  public class ClientCredit : Client
  {
    protected override Commande CreerCommande(double montant)
    {
      return new CommandeCredit(montant);
    }
  }
}