namespace Abstract_Factory
{
    public interface IFabriquerVehicule
    {
        Automobile CreerAutomobile(string modele, string couleur, int puissance, double espace);
        Scooter CreerScooter(string modele, string couleur, int puissance);
    }
}