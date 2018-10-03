using System;


namespace Mediator
{
    public abstract class Controle
    {
        public string Valeur { get; protected set; }
        public Formulaire Directeur { get; set; }
        public string Nom { get; protected set; }

        public Controle(string nom)
        {
            Valeur = "";
            Nom = nom;
        }

        public abstract void saisie();

        protected void Modifie()
        {
            Directeur.ControleModifie(this);
        }
    }
}