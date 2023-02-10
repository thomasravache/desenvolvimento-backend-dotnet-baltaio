var builder = WebApplication.CreateBuilder(args); // Cria a aplicação web
var app = builder.Build(); // construir a aplicação

app.MapGet("/", () => "Hello World!");
app.MapGet("/xablau", () => "xablau!");

app.Run(); // rodar a aplicação
