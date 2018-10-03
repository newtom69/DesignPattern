using System;

namespace ChainOfResponsibility
{
    public class Vehicule : ObjetBase
    {
        protected string LaDescription;

        public Vehicule(string description) => LaDescription = description;

        protected override string Description => LaDescription;
    }
}