using System;

namespace Prototype
{
  public class CertificatCession : Document
  {
    public override void Affiche()
    {
      Console.WriteLine( "Affiche le certificat de cession : " + contenu);
    }

    public override void Imprime()
    {
      Console.WriteLine( "Imprime le certificat de cession : " + contenu);
    }
  }
}
