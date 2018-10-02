using System;

namespace Abstract_Factory
{
    public class ScooterHybride : Scooter
    {
        public ScooterHybride(string modele, string couleur, int puissance) : base(modele, couleur, puissance)
        {}

        public override void AfficherCaracteristiques()
        {
            Console.WriteLine($"Scooter hybride de modèle {modele} de couleur {couleur} de puissance {puissance}");
        }
    }
}