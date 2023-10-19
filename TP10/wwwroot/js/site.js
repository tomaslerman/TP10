// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function MostrarTemporadas(IdS)
{
    $.ajax(     
        {
            type:'POST',
            dataType:'JSON',
            url:'/Home/infoTemporadas',
            data:{IdSerie:IdS},
            success:
                function(response)
                {
                    $("#Info").html(response.numeroTemporada);
                    $("#Info").html(response.tituloTemporada);
                }


        }

    );
}

function MostrarActores(IdS)
{
    $.ajax(
            {
                type:'POST',
                dataType:'JSON',
                url:'/Home/infoActores',
                data:{IdSerie:IdS},
                success:
                function(response)
                {
                    $("#Info").html(response.nombre);
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
                    $("#Info").html(response.nombre);
                    $("#Info").html(response.añoInicio);
                    $("#Info").html(response.sinopsis);
                    $("#Info").html(response.imagenSerie);
                }
            }
    );
}