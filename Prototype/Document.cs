using System;
namespace Prototype
{
  public abstract class Document
  {
    protected string contenu = "";

    public Document Duplique()
    {
      Document resultat;
      resultat = (Document)this.MemberwiseClone();
      return resultat;
    }

    public void Remplit(string informations)
    {
      contenu = informations;
    }

    public abstract void Imprime();
    public abstract void Affiche();
  }
}