using System;
using System.Collections.Generic;

namespace Mediator
{
    public class PopupMenu : Controle
    {
        protected IList<string> _options = new List<string>();

        public PopupMenu(string nom) : base(nom) { }

        public override void saisie()
        {
            Console.WriteLine("Saisie de : " + Nom);
            Console.WriteLine("Valeur actuelle : " + Valeur);
            for (int index = 0; index < _options.Count; index++)
                Console.WriteLine("- " + index + " )" +
                  _options[index]);
            int choix = int.Parse(Console.ReadLine());
            if ((choix >= 0) && (choix < _options.Count))
            {
                bool change = (Valeur != _options[choix]);
                if (change)
                {
                    Valeur = _options[choix];
                    this.Modifie();
                }
            }
        }

        public void AjouteOption(string option)
        {
            _options.Add(option);
        }
    }
}