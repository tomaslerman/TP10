using Microsoft.AspNetCore.Mvc;

namespace TP10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSerie();
        return View();
    }
  public Temporadas infoTemporadas(int IdSerie)
  {
    Temporadas Temp = BD.ObtenerTemporada(IdSerie);
    return Temp;
  }
   public Actores infoActores(int IdSerie)
  {
    Actores Act = BD.ObtenerActor(IdSerie);
    return Act;
  }
  public Series infoSeries(int IdSerie)
  {
    Series Ser = BD.ObtenerSeriePorId(IdSerie);
    return Ser;
  }
}
