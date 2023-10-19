// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function MostrarTemporadas(IdS)
{
    let Temporada= "";
    $.ajax(     
        {
            type:'POST',
            dataType:'JSON',
            url:'/Home/infoTemporadas',
            data:{IdSerie:IdS},
            success:
                function(response)
                {
                    $("#ModalTitulo").html("Temporadas");
                    response.forEach(element => {
                        Temporada += "Numero temporada: " + element.numeroTemporada + "<br>";
                        Temporada += "Titulo temporada: " + element.tituloTemporada + "<br>";
                        $("#Info").html(Temporada);
                }   );
            }
        }

    );
}

function MostrarActores(IdS)
{
    let Actores="";
    $.ajax(
            {
                type:'POST',
                dataType:'JSON',
                url:'/Home/infoActores',
                data:{IdSerie:IdS},
                success:
                function(response)
                {
                    $("#ModalTitulo").html("Actores");
                    response.forEach(element => {
                        Actores += element.nombre + "<br>";
                        $("#Info").html(Actores);
                }   );
            }
        }
    );
}

function MostrarSerie(IdS)
{
    $.ajax(
            {
                type:'POST',
                dataType:'JSON',
                url:'/Home/infoSeries',
                data:{IdSerie:IdS},
                success:
                function(response)
                {
                    $("#ModalTitulo").html("Informacion de la serie");
                    $("#Info").html(response.añoInicio);
                    $("#Info").html(response.sinopsis);
                }
            }
    );
}