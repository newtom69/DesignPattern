namespace Abstract_Factory
{
    class FabriquerVehiculeElectrique : IFabriquerVehicule
    {
        public Automobile CreerAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileElectrique(modele, couleur, puissance, espace);
        }

        public Scooter CreerScooter(string modele, string couleur, int puissance)
        {
            return new ScooterElectrique(modele, couleur, puissance);
        }
    }
}
