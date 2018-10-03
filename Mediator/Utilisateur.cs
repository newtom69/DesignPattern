namespace Mediator
{
    public class Utilisateur
    {
        public void LoadMediator()
        {
            Formulaire Formulaire = new Formulaire();
            Formulaire.AjouteControle(new ZoneSaisie("Nom"));
            Formulaire.AjouteControle(new ZoneSaisie("Prénom"));
            PopupMenu menu = new PopupMenu("Coemprunteur");
            menu.AjouteOption("sans coemprunteur");
            menu.AjouteOption("avec coemprunteur");
            Formulaire.AjouteControle(menu);
            Formulaire.MenuCoemprunteur = menu;
            Bouton LeBouton = new Bouton("OK");
            Formulaire.AjouteControle(LeBouton);
            Formulaire.BoutonOK = LeBouton;
            Formulaire.ajouteControleCoemprunteur(new ZoneSaisie("Nom du coemprunteur"));
            Formulaire.ajouteControleCoemprunteur(new ZoneSaisie("Prénom du coemprunteur"));
            Formulaire.saisie();

        }

    }
}