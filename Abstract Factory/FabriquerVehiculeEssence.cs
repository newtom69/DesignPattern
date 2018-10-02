namespace Abstract_Factory
{
    class FabriquerVehiculeEssence : IFabriquerVehicule
    {
        public Automobile CreerAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileEssence(modele, couleur, puissance, espace);
        }

        public Scooter CreerScooter(string modele, string couleur, int puissance)
        {
            return new ScooterEssence(modele, couleur, puissance);
        }
    }
}
