using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class LiassePdf : Liasse
    {
        public override void AjouteDocument(string document)
        {
            if (document.StartsWith("<PDF>"))
                contenu.Add(document);
        }

        public override void Imprime()
        {
            Console.WriteLine("Liasse PDF");
            foreach (string s in contenu)
                Console.WriteLine(s);
        }
    }
}
