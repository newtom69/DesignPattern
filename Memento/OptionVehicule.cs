using System;
using System.Collections.Generic;

namespace Memento
{
    public class OptionVehicule
    {
        protected string _nom;
        public IList<OptionVehicule> OptionsIncompatibles { get; protected set; }

        public OptionVehicule(string nom)
        {
            OptionsIncompatibles = new List<OptionVehicule>();
            _nom = nom;
        }

        public void AjouterOptionIncompatible(OptionVehicule option)
        {
            if (!OptionsIncompatibles.Contains(option))
            {
                OptionsIncompatibles.Add(option);
                option.AjouterOptionIncompatible(this);
            }
        }

        public void Afficher()
        {
            Console.WriteLine("option : " + _nom);
        }
    }
}