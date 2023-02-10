var builder = WebApplication.CreateBuilder(args); // Cria a aplicação web
var app = builder.Build(); // construir a aplicação

app.MapGet("/", () =>
{
    return Results.Ok("Hello World!"); // retorna status 200
});
app.MapGet("/{nome}", (string nome) =>
{
    return Results.Ok($"Hello {nome}");
});

app.Run(); // rodar a aplicação
