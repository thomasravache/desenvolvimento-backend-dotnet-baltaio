var builder = WebApplication.CreateBuilder(args);

// Diz pro ASP.NET que a API está dividida em controllers
// Procura tudo que tem o sufixo Controller e herda de um ControllerBase
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers(); // Faz a mesma função do MapGet, MapPost etc...

app.Run();
