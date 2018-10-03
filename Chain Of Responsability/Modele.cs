using System;

namespace ChainOfResponsibility
{
    public class Modele : ObjetBase
    {
        protected string _laDescription;
        protected string _nom;

        public Modele(string nom, string description)
        {
            _laDescription = description;
            _nom = nom;
        }

        protected override string Description
        {
            get
            {
                if (_laDescription != null)
                    return $"Modèle  {_nom} : {_laDescription}";
                else
                    return null;
            }
        }
    }
}