namespace Adapter
{
    public class DocumentPdf : Document
    {
        protected ComposantPdf outilPdf = new ComposantPdf();

        public string contenu
        {
            set
            {
                outilPdf.PdfFixeContenu(value);
            }
        }

        public void dessine()
        {
            outilPdf.PdfPrepareAffichage();
            outilPdf.PdfRafraichit();
            outilPdf.PdfTermineAffichage();
        }

        public void imprime()
        {
            outilPdf.PdfEnvoieImprimante();
        }
    }
}