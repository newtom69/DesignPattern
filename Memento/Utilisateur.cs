
using System;

namespace Memento
{
    public class Utilisateur
    {

        public void LoadMemento()
        {
            Memento memento;
            OptionVehicule option1 = new OptionVehicule("Sièges en cuir");
            OptionVehicule option2 = new OptionVehicule("Accoudoirs");
            OptionVehicule option3 = new OptionVehicule("Sièges sportifs");
            option1.AjouterOptionIncompatible(option3);
            option2.AjouterOptionIncompatible(option3);
            ChariotOption chariotOptions = new ChariotOption();
            chariotOptions.ajouteOption(option1);
            chariotOptions.ajouteOption(option2);
            chariotOptions.affiche();
            Console.WriteLine("Ajout d'une option incompatible...");
            memento = chariotOptions.ajouteOption(option3);
            chariotOptions.affiche();
            Console.WriteLine("Annulation dernière option...");
            chariotOptions.annule(memento);
            chariotOptions.affiche();
        }
    }
}