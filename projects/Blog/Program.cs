using System.Text;
using Blog;
using Blog.Data;
using Blog.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

ConfigureAuthentication(builder);
ConfigureMvc(builder);
ConfigureServices(builder);

var app = builder.Build();

LoadConfiguration(app);

// Sempre nessa ordem: autenticação antes da autorização
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();

void LoadConfiguration(WebApplication app)
{
    // app.Configuration.GetSection("Smtp); // pega uma chave do json no appsettings
    // app.Configuration.GetValue<string>("JwtKey"); // pega uma chave do json no appsettings

    Configuration.JwtKey = app.Configuration.GetValue<string>("JwtKey");
    Configuration.ApiKeyName = app.Configuration.GetValue<string>("ApiKeyName");
    Configuration.ApiKey = app.Configuration.GetValue<string>("ApiKey");

    var smtp = new Configuration.SmtpConfiguration();
    app.Configuration.GetSection("Smtp").Bind(smtp);
    Configuration.Smtp = smtp;
}

void ConfigureAuthentication(WebApplicationBuilder builder)
{
    var key = Encoding.ASCII.GetBytes(Configuration.JwtKey);

    builder
        .Services
        .AddAuthentication(x =>
        {
            /* configura qual esquema de autenticação iremos utilizar */
            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; // Também é mais útil para autenticar uma múltiplas API's
        }).AddJwtBearer(x => // informar como vamos desencriptar este token
        {
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                // As duas opções abaixo seriam úteis para autenticar múltiplas API's
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });
}

void ConfigureMvc(WebApplicationBuilder builder)
{
    builder
        .Services
        .AddControllers()
        .ConfigureApiBehaviorOptions(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });
}

void ConfigureServices(WebApplicationBuilder builder)
{
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

    // builder.Services.AddScoped();
    // builder.Services.AddSingleton();
    builder.Services.AddTransient<TokenService>();
    builder.Services.AddTransient<EmailService>();
}