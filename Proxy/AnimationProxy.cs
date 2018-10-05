using System;

namespace Proxy
{
  public class AnimationProxy : IAnimation
  {
    protected Film film = null;
    protected string photo = "affichage de la photo";

    public void Clic()
    {
      if (film == null)
      {
        film = new Film();
        film.Charge();
      }
      film.Joue();
    }

    public void Dessine()
    {
      if (film != null)
        film.Dessine();
      else
        Dessine(photo);
    }

    public void Dessine(string photo)
    {
      Console.WriteLine(photo);
    }
  }
}