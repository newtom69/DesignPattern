using System;

namespace Bridge
{
  public abstract class FormulaireImmatriculation
  {
    protected string contenu;
    protected FormulaireImpl implantation;

    public FormulaireImmatriculation(FormulaireImpl
      implantation)
    {
      this.implantation = implantation;
    }

    public void Affiche()
    {
      implantation.DessineTexte(
        "num�ro de la plaque existante : ");
    }

    public void GenereDocument()
    {
      implantation.DessineTexte("Demande d'immatriculation");
      implantation.DessineTexte("num�ro de plaque : " +
        contenu);
    }

    public bool GereSaisie()
    {
      contenu = implantation.GereZoneSaisie();
      return this.ControleSaisie(contenu);
    }

    protected abstract bool ControleSaisie(string plaque);
  }
}