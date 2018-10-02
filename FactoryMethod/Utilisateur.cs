using System;

namespace FactoryMethod
{
  public class Utilisateur
  {
    public void LoadFactoryMethod()
    {
      Client client;
      client = new ClientComptant();
      client.NouvelleCommande(2000.0);
      client.NouvelleCommande(10000.0);
      client = new ClientCredit();
      client.NouvelleCommande(2000.0);
      client.NouvelleCommande(10000.0);
      Console.ReadLine();
    }
  }
}