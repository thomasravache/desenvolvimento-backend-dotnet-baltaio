var builder = WebApplication.CreateBuilder(args); // Cria a aplicação web
var app = builder.Build(); // construir a aplicação

app.MapGet("/", () => "Hello World!");

app.Run(); // rodar a aplicação
