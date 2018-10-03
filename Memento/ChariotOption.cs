using System;
using System.Collections.Generic;


namespace Memento
{
    public class ChariotOption
    {
        protected IList<OptionVehicule> options = new List<OptionVehicule>();

        public Memento ajouteOption(OptionVehicule optionVehicule)
        {
            Memento resultat = new Memento();
            resultat.LesOptions = options;
            IList<OptionVehicule> optionsIncompatibles = optionVehicule.OptionsIncompatibles;

            foreach (OptionVehicule option in optionsIncompatibles)
                options.Remove(option);

            options.Add(optionVehicule);

            return resultat;
        }

        public void annule(Memento memento)
        {
            Memento mementoImplInstance = memento as Memento;

            if (mementoImplInstance == null)
                return;

            options = mementoImplInstance.LesOptions;
        }

        public void affiche()
        {
            Console.WriteLine("Contenu du chariot des options");
            foreach (OptionVehicule option in options)
                option.Afficher();

            Console.WriteLine();
        }
    }
}