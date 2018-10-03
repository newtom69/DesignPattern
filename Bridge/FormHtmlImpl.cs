using System;

namespace Bridge
{
  public class FormHtmlImpl : FormulaireImpl
  {

    public void DessineTexte(string texte)
    {
      Console.WriteLine("HTML : " + texte);
    }

    public string GereZoneSaisie()
    {
      return Console.ReadLine();
    }
  }
}