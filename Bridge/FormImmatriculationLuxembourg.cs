using System;

namespace Bridge
{
  public class FormImmatriculationLuxembourg :
    FormulaireImmatriculation
  {
    public FormImmatriculationLuxembourg(FormulaireImpl
      implantation) : base(implantation) { }

    protected override bool ControleSaisie(string plaque)
    {
      return plaque.Length == 5;
    }
  }
}