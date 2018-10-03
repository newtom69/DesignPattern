using System;

namespace Bridge
{
  public class FormImmatriculationFrance :
    FormulaireImmatriculation
  {
    public FormImmatriculationFrance(FormulaireImpl
      implantation) : base(implantation) { }

    protected override bool ControleSaisie(string plaque)
    {
      return plaque.Length == 7;
    }
  }
}