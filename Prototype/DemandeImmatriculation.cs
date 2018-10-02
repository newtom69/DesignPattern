using System;
namespace Prototype
{
  public class DemandeImmatriculation : Document
  {
    public override void Affiche()
    {
      Console.WriteLine("Affiche la demande d'immatriculation : " + contenu);
    }

    public override void Imprime()
    {
      Console.WriteLine( "Imprime la demande d'immatriculation : " + contenu);
    }
  }
}