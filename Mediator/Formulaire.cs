using System.Collections.Generic;
using System;

namespace Mediator
{
    public class Formulaire
    {
        protected IList<Controle> _controles = new List<Controle>();
        protected IList<Controle> _controlesCoemprunteur = new List<Controle>();
        public PopupMenu MenuCoemprunteur { protected get; set; }
        public Bouton BoutonOK { protected get; set; }
        protected bool _enCours = true;

        public void AjouteControle(Controle controle)
        {
            _controles.Add(controle);
            controle.Directeur = this;
        }

        public void ajouteControleCoemprunteur(Controle
          controle)
        {
            _controlesCoemprunteur.Add(controle);
            controle.Directeur = this;
        }

        public void ControleModifie(Controle controle)
        {
            if (controle == MenuCoemprunteur)
                if (controle.Valeur == "avec coemprunteur")
                {
                    foreach (Controle elementCoemprunteur in
                     _controlesCoemprunteur)
                        elementCoemprunteur.saisie();
                }
            if (controle == BoutonOK)
            {
                _enCours = false;
            }
        }

        public void saisie()
        {
            while (true)
            {
                foreach (Controle controle in _controles)
                {
                    controle.saisie();
                    if (!_enCours)
                        return;
                }
            }
        }

    }
}