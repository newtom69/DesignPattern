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
            // initialisation du vendeur du syst�me
            Vendeur leVendeur = Vendeur.Instance();
            leVendeur.nom = "Vendeur Auto";
            leVendeur.adresse = "Paris";
            leVendeur.email = "vendeur@vendeur.com";
            // affichage du vendeur du syst�me
            affiche();
            Vendeur leVendeur2 = Vendeur.Instance();
            Console.WriteLine("cr�ation autre instance. V�rification des donn�es :");
            affiche();
            leVendeur2.nom = "Vendeur Auto Thomas";
            leVendeur2.adresse = "Lyon";
            leVendeur2.email = "vendeur@vendeurtom.com";
            Console.WriteLine("Remplissage donn�es de l'instance. V�rification des donn�es :");
            affiche();

        }
    }
}