using System;
using System.Collections.Generic;


namespace Memento
{
    public class ChariotOption
    {
        protected IList<OptionVehicule> options = new List<OptionVehicule>();

        public Memento ajouteOption(OptionVehicule optionVehicule)
        {
            MementoImpl resultat = new MementoImpl();
            resultat.LesOptions = options;
            IList<OptionVehicule> optionsIncompatibles = optionVehicule.OptionsIncompatibles;

            foreach (OptionVehicule option in optionsIncompatibles)
                options.Remove(option);

            options.Add(optionVehicule);

            return resultat;
        }

        public void annule(Memento memento)
        {
            MementoImpl mementoImplInstance = memento as MementoImpl;

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