using System;

namespace FactoryMethod
{
  public abstract class Commande
  {
    protected double _montant;

    public Commande(double montant)
    {
      _montant = montant;
    }

    public abstract bool Valide();
    public abstract void Paye();
    public abstract void PayeKo();
    }
}