using System;

namespace Bridge
{
  public class Utilisateur
  {
    public void LoadBridge() {
      FormImmatriculationLuxembourg formulaire1 = new FormImmatriculationLuxembourg(new FormHtmlImpl());
      formulaire1.Affiche();
      if (formulaire1.GereSaisie())
        formulaire1.GenereDocument();
      Console.WriteLine();
      FormImmatriculationFrance formulaire2 = new FormImmatriculationFrance(new FormAppletImpl());
      formulaire2.Affiche();
      if (formulaire2.GereSaisie())
        formulaire2.GenereDocument();
      
    }
  }
}