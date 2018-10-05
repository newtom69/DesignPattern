using System;

namespace Decorator
{
  public class VueCatalogue
  {
    public void LoadDecorator(){
      VueVehicule vueVehicule = new VueVehicule();
      ModeleDecorateur modeleDecorateur = new
        ModeleDecorateur(vueVehicule);
      MarqueDecorateur marqueDecorateur = new
        MarqueDecorateur(modeleDecorateur);
      marqueDecorateur.affiche();
    }
  }
}