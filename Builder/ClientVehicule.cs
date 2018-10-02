using System;

namespace Builder
{
    public class ClientVehicule
    {

        public void LoadBuilder()
        {
            ConstructeurLiasseVehicule constructeur;
            Console.WriteLine("Voulez-vous construire " + "des liasses HTML (1), PDF (2), ODT (3) :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else if (choix == "2")
            {
                constructeur = new ConstructeurLiasseVehiculePdf();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculeOdt();
            }

            Vendeur vendeur = new Vendeur(constructeur);
            Liasse liasse = vendeur.Construit("Martin");
            liasse.Imprime();

        }
    }
}