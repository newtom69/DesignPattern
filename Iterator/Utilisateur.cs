using System;

namespace Iterator
{
    public class Utilisateur
    {

        public void LoadIterator()
        {
            CatalogueVehicule catalogue = new CatalogueVehicule();
            IterateurVehicule iterateur = catalogue.recherche("bon marché");
            Vehicule vehicule;
            iterateur.debut();
            vehicule = iterateur.item();
            while (vehicule != null)
            {
                vehicule.affiche();
                iterateur.suivant();
                vehicule = iterateur.item();
            }
        }

    }
}