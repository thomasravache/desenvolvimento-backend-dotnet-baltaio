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

app.MapPost("/", (User user) =>
{
    /*
        JSON pra objeto CSharp = serialização
        objeto CSharp pra JSON = deserialização
    */
    return Results.Ok(user);
});

app.Run(); // rodar a aplicação

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
}