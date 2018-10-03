using System;


namespace Adapter
{
    public class ServeurWeb
    {

        public void LoadAdapter()
        {
            Document document1, document2, document3;
            document1 = new DocumentHtml();
            document1.contenu = "Hello";
            document1.dessine();
            Console.WriteLine();
            document2 = new DocumentPdf();
            document2.contenu = "Bonjour";
            document2.dessine();
            Console.WriteLine();
            document3 = new DocumentOdt();
            document3.contenu = "Bonjour en version ODT";
            document3.dessine();
        }
    }
}