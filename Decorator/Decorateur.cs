namespace Decorator
{
  public abstract class Decorateur : ComposantGraphiqueVehicule
  {
    protected ComposantGraphiqueVehicule _composant;

    public Decorateur(ComposantGraphiqueVehicule composant)
    {
      this._composant = composant;
    }

    public virtual void affiche()
    {
      _composant.affiche();
    }
  }
}