namespace ChainOfResponsibility
{
    public abstract class ObjetBase
    {
        public ObjetBase Suivant { protected get; set; }

        private string DescriptionParDefaut()
        {
            return "description par défaut";
        }

        protected abstract string Description { get; }

        public string DonneDescription()
        {
            string resultat;
            resultat = Description;
            if (resultat != null)
                return resultat;
            if (Suivant != null)
                return Suivant.DonneDescription();
            else
                return DescriptionParDefaut();
        }
    }
}