using System;


namespace Bridge
{
  public class FormAppletImpl : FormulaireImpl
  {

    public void DessineTexte(string texte)
    {
      Console.WriteLine("Applet : " + texte);
    }

    public string GereZoneSaisie()
    {
      return Console.ReadLine();
    }
  }
}