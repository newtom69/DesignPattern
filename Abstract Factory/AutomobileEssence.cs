using System;

namespace Abstract_Factory
{
    public class AutomobileEssence : Automobile
    {
        public AutomobileEssence(string modele, string couleur, int puissance, double espace) : base(modele, couleur, puissance, espace)
        { }

        public override void AfficherCaracteristiques()
        {
            Console.WriteLine($"Automobile à essence de modèle : {modele} de couleur {couleur} de puissance : {puissance} d’espace : {espace}");
        }
    }
}