using System;

namespace ChainOfResponsibility
{
    public class Marque : ObjetBase
    {
        protected string _description1, _description2;
        protected string _nom;

        public Marque(string nom, string description1, string description2)
        {
            _description1 = description1;
            _description2 = description2;
            _nom = nom;
        }

        protected override string Description
        {
            get
            {
                if ((_description1 != null) && (_description2 != null))
                    return $"Marque {_nom} : {_description1} {_description2}";
                else if (_description1 != null)
                    return $"Marque {_nom} : {_description1}";
                else
                    return "";
            }
        }
    }
}