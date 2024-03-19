

using MinimalAPIPeliculas.Entidades;

var builder = WebApplication.CreateBuilder(args);

var apellido = builder.Configuration.GetValue<string>("apellido");

// Servicios 


var app = builder.Build();

// MiddleWare

app.MapGet("/", () => apellido);
app.MapGet("/otra-cosa", () => apellido);

app.MapGet("/generos", () =>
    {
        var generos = new List<Genero>  


    }
   );


// Fin del MiddleWare

app.Run();
