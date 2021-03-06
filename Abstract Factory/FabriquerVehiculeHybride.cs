﻿namespace Abstract_Factory
{
    class FabriquerVehiculeHybride : IFabriquerVehicule
    {
        public Automobile CreerAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileHybride(modele, couleur, puissance, espace);
        }

        public Scooter CreerScooter(string modele, string couleur, int puissance)
        {
            return new ScooterHybride(modele, couleur, puissance);
        }
    }
}
