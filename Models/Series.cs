using System.Collections.Generic;
using System.Data.SqlClient;

namespace TP10;
public class Series
{
    public int IdSerie {get; set;}
    public string Nombre {get;set;}
    public int AñoInicio {get; set;}
    public string Sinopsis {get;set;}
    public string ImagenSerie {get;set;}
}