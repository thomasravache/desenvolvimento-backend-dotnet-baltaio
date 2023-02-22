using Blog.Data;
using Blog.Services;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });
builder.Services.AddDbContext<BlogDataContext>(); // para dataContext sempre utilizar o AddDbContext

/*
    Diferença do Transient, Scoped e Singleton é o tempo de vida da dependência

    AddTransient -->
        Sempre cria uma nova instancia quando você precisar (instanciar)

    AddScoped -->
        Dura por transação sempre que fizer um "request" ele reaproveita a instância
        naquela requisição, depois que finalizar a requisição ele mata o serviço solicitado

    AddSingleton -->
        Uma instância por App, ou seja, depois que a aplicação subir ele vai carregar uma vez só
        e vai ficar lá na memória do app pra sempre
*/
builder.Services.AddTransient<TokenService>();
// builder.Services.AddScoped();
// builder.Services.AddSingleton();

var app = builder.Build();

app.MapControllers();

app.Run();
