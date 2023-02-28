using Blog.Data;
using Blog.Extensions;
using Blog.Models;
using Blog.Services;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecureIdentity.Password;

namespace Blog.Controllers;

// [Authorize] // pode ser passado em cada método ou no controller todo
[ApiController]
public class AccountController : ControllerBase
{
    /*
        Criar uma dependência do que sua classe precisa pra trabalhar

        Até a linha 20 seria a mesma coisa que utilizar um FromServices no método desejado
    */
    private readonly TokenService _tokenService;

    public AccountController(TokenService tokenService)
    {
        _tokenService = tokenService;
    }

    [HttpPost("v1/accounts")]
    public async Task<IActionResult> Post(
        [FromBody] RegisterViewModel model,
        [FromServices] EmailService emailService,
        [FromServices] BlogDataContext context
    )
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var user = new User
        {
            Name = model.Name,
            Email = model.Email,
            Slug = model.Email.Replace("@", "-").Replace(".", "-")
        };

        var password = PasswordGenerator.Generate(25);

        user.PasswordHash = PasswordHasher.Hash(password); // senha encriptada pronta pra ser salva no banco

        try
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            emailService.Send(
                user.Name, user.Email, "Bem vindo ao blog!", $"Sua senha é: <br/><br/> <strong>{password}</strong>"
            );

            return Ok(new ResultViewModel<dynamic>(new
            {
                user = user.Email,
                password // ideal é não mostrar isso no retorno e sim mandar por e-mail
            }));
        }
        catch (DbUpdateException)
        {
            return StatusCode(
                StatusCodes.Status400BadRequest,
                new ResultViewModel<string>("05X99 - Este e-mail já existe.")
            );
        }
        catch
        {
            return StatusCode(
                StatusCodes.Status500InternalServerError,
                new ResultViewModel<string>("05X04 - Falha interna no servidor")
            );
        }
    }

    // [AllowAnonymous] // Permite que seja feita a requisição sem passar token
    [HttpPost("v1/accounts/login")]
    public async Task<IActionResult> Login(
        [FromBody] LoginViewModel model,
        [FromServices] BlogDataContext context
    )
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var user = await context
            .Users
            .AsNoTracking()
            .Include(x => x.Roles)
            .FirstOrDefaultAsync(x => x.Email == model.Email);

        if (user == null)
            return StatusCode(StatusCodes.Status401Unauthorized, new ResultViewModel<string>("Usuário ou senha inválidos"));

        if (!PasswordHasher.Verify(user.PasswordHash, model.Password))
            return StatusCode(StatusCodes.Status401Unauthorized, new ResultViewModel<string>("Usuário ou senha inválidos"));

        try
        {
            var token = _tokenService.GenerateToken(user);

            return Ok(new ResultViewModel<string>(token, null));
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new ResultViewModel<string>("05X04 - Falha interna no servidor"));
        }
    }
}