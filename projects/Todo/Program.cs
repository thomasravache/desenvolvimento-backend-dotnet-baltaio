using Todo.Data;

var builder = WebApplication.CreateBuilder(args);

// Diz pro ASP.NET que a API está dividida em controllers
// Procura tudo que tem o sufixo Controller e herda de um ControllerBase
builder.Services.AddControllers();

/*
    Deixa o DbContext como um serviço,
    agora pode ser usado direto da aplicação como se fosse um serviço
    e o ASP.NET que vai administrar quando a conexão será aberta ou fechada (faz uma conexão por requisição)
*/
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapControllers(); // Faz a mesma função do MapGet, MapPost etc...

app.Run();
