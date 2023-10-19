using Microsoft.AspNetCore.Mvc;

namespace TP10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSerie();
        return View();
    }
  public List<Temporadas> infoTemporadas(int IdSerie)
  {
    List<Temporadas> Temp = BD.ObtenerTemporada(IdSerie);
    return Temp;
  }
   public List<Actores> infoActores(int IdSerie)
  {
    List<Actores> Act = BD.ObtenerActor(IdSerie);
    return Act;
  }
  public Series infoSeries(int IdSerie)
  {
    Series Ser = BD.ObtenerSeriePorId(IdSerie);
    return Ser;
  }
}
