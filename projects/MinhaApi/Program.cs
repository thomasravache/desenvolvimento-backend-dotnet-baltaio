var builder = WebApplication.CreateBuilder(args); // Cria a aplicação web
var app = builder.Build(); // construir a aplicação

app.MapGet("/", () =>
{
    return "Hello World!";
});
// app.MapGet("/", Teste);
app.MapGet("/xablau", () => "xablau!");

app.Run(); // rodar a aplicação

// string Teste()
// {
//     return "Hello World!";
// }