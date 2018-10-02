using System;

namespace Builder
{
    public class ConstructeurLiasseVehiculeOdt : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeOdt()
        {
            liasse = new LiasseOdt();
        }

        public override void ConstruitBonDeCommande(string nomClient)
        {
            string document = "<ODT>Bon de commande Client : " + nomClient + "</ODT>";
            liasse.AjouteDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomDemandeur)
        {
            string document = "<ODT>Demande d'immatriculation Demandeur : " + nomDemandeur + "</ODT>";
            liasse.AjouteDocument(document);
        }
    }
}