using System;
using System.Collections.Generic;
using Abstract_Factory;

namespace Abstract_Factory
{
    public class Catalogue
    {
        public static int nbAutos = 3;
        public static int nbScooters = 2;

        public void LoadCatalogue()
        {
            bool continuer = true;

            List<Automobile> autos = new List<Automobile>();
            List<Scooter> scooters = new List<Scooter>();

            while (continuer)
            {
                IFabriquerVehicule fabrique = null;
                Console.WriteLine("Voulez-vous utiliser un véhicule Automobile (1) ou Scooter (2)");
                string choixTypeVehicule = Console.ReadLine();
                Console.WriteLine("Voulez-vous utiliser un véhicule électriques (1) à essence (2) hybride (3):");
                string choixMotorisation = Console.ReadLine();
               

                if (choixMotorisation == "1")
                    fabrique = new FabriquerVehiculeElectrique();
                else if (choixMotorisation == "2")
                    fabrique = new FabriquerVehiculeEssence();
                else if (choixMotorisation == "3")
                    fabrique = new FabriquerVehiculeHybride();
                 
                if (choixTypeVehicule == "1")
                    autos.Add(fabrique.CreerAutomobile("standard", "jaune", 6, 3.2));
                else if (choixTypeVehicule == "2")
                    scooters.Add(fabrique.CreerScooter("classic", "rouge", 2));


                Console.WriteLine("continuer ? O/N");
                string result = Console.ReadLine();
                if (result == "O" || result == "o")
                    continuer = true;
                else
                    continuer = false;
            }

            //affichage des véhicules
            foreach (Automobile auto in autos)
                auto.AfficherCaracteristiques();

            foreach (Scooter scooter in scooters)
                scooter.AfficherCaracteristiques();
        }

    }

}