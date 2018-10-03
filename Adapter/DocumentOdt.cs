namespace Adapter
{
    public class DocumentOdt : Document
    {
        protected ComposantOdt outilOdt = new ComposantOdt();

        public string contenu
        {
            set
            {
                outilOdt.OdtFixeContenu(value);
            }
        }

        public void dessine()
        {
            outilOdt.OdtPrepareAffichage();
            outilOdt.OdtRafraichit();
            outilOdt.OdtTermineAffichage();
        }

        public void imprime()
        {
            outilOdt.OdtEnvoieImprimante();
        }
    }
}