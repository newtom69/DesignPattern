using System;

namespace Abstract_Factory
{
    public class ScooterElectrique : Scooter
    {
        public ScooterElectrique(string modele, string couleur, int puissance) : base(modele, couleur, puissance)
        {}

        public override void AfficherCaracteristiques()
        {
            Console.WriteLine($"Scooter électrique de modèle {modele} de couleur {couleur} de puissance {puissance}");
        }
    }
}