using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using TP10.Models;

namespace TP10;

public static class BD
{
    private static string _connectionString = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;"; //cambiar a localhost

     public static List<Series> ObtenerSerie()
    {
        using (SqlConnection DB = new SqlConnection(_connectionString)){
            string SQL = "select * from Series";
            return DB.Query<Series>(SQL).ToList();        
        }
    }
    public static Temporadas ObtenerTemporada(int IdSerie)
    {
        using (SqlConnection DB = new SqlConnection(_connectionString)){
        string SQL = "select * from Temporadas where IdSerie = @pIdSerie";
            return DB.QueryFirstOrDefault<Temporadas>(SQL, new{pIdSerie= IdSerie});
        }
    }
    public static Actores ObtenerActor(int IdSerie)
    {
        using (SqlConnection DB = new SqlConnection(_connectionString)){
        string SQL = "select * from Actores where IdSerie = @pIdSerie";
            return DB.QueryFirstOrDefault<Actores>(SQL, new{pIdSerie= IdSerie});
        }
    }
    public static Series ObtenerSeriePorId(int IdSerie)
    {
        using (SqlConnection DB = new SqlConnection(_connectionString)){
        string SQL = "select * from Series where IdSerie = @pIdSerie";
            return DB.QueryFirstOrDefault<Series>(SQL, new{pIdSerie= IdSerie});
        }
    }
}
