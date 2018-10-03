using System;

namespace Prototype
{
  public class Utilisateur
  {
    public void LoadPrototype(){
      LiasseVierge liasseVierge = LiasseVierge.Instance();
      liasseVierge.Ajoute(new BonDeCommande());
      liasseVierge.Ajoute(new CertificatCession());
      liasseVierge.Ajoute(new DemandeImmatriculation());
      // création d'une nouvelle liasse pour deux clients
      LiasseClient liasseClient1 = new LiasseClient("Martin");
      liasseClient1.affiche();

      LiasseClient liasseClient2 = new LiasseClient("Durant");
      liasseClient2.affiche();
      
    }
  }
}