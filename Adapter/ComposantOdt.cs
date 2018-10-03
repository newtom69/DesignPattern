using System;

namespace Adapter
{
    public class ComposantOdt
    {
        protected string contenu;

        public void OdtFixeContenu(string contenu)
        {
            this.contenu = contenu;
        }

        public void OdtPrepareAffichage()
        {
            Console.WriteLine("Affichage ODT : Début");
        }

        public void OdtRafraichit()
        {
            Console.WriteLine("Affichage contenu ODT : " +
              contenu);
        }

        public void OdtTermineAffichage()
        {
            Console.WriteLine("Affichage ODT : Fin");
        }

        public void OdtEnvoieImprimante()
        {
            Console.WriteLine("Impression ODT : " + contenu);
        }
    }
}