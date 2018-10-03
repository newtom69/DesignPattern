using System;

namespace Singleton
{
    public class TestVendeur
    {
        public static void affiche()
        {
            Vendeur leVendeur = Vendeur.Instance();
            leVendeur.affiche();
        }

        public void LoadSingleton()
        {
            // initialisation du vendeur du système
            Vendeur leVendeur = Vendeur.Instance();
            leVendeur.nom = "Vendeur Auto";
            leVendeur.adresse = "Paris";
            leVendeur.email = "vendeur@vendeur.com";
            // affichage du vendeur du système
            affiche();
            Vendeur leVendeur2 = Vendeur.Instance();
            Console.WriteLine("création autre instance. Vérification des données :");
            affiche();
            leVendeur2.nom = "Vendeur Auto Thomas";
            leVendeur2.adresse = "Lyon";
            leVendeur2.email = "vendeur@vendeurtom.com";
            Console.WriteLine("Remplissage données de l'instance. Vérification des données :");
            affiche();

        }
    }
}