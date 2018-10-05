
namespace Proxy
{
  public class VueVehicule
  {
    public void LoadProxy() {
      IAnimation animation = new AnimationProxy();
      animation.Dessine();
      animation.Clic();
      animation.Dessine();
    }
  }
}