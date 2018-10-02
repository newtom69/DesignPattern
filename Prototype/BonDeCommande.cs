using System;

namespace Prototype
{
  public class BonDeCommande : Document
  {
    public override void Affiche()
    {
      Console.WriteLine("Affiche le bon de commande : " + contenu);
    }

    public override void Imprime()
    {
      Console.WriteLine("Imprime le bon de commande : " + contenu);
    }
  }
}
