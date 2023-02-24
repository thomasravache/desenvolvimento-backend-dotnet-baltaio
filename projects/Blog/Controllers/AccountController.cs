using Blog.Data;
using Blog.Extensions;
using Blog.Models;
using Blog.Services;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

        return Ok();
    }

    // [AllowAnonymous] // Permite que seja feita a requisição sem passar token
    [HttpPost("v1/login")]
    public IActionResult Login()
    {
        // var tokenService = new TokenService();
        var token = _tokenService.GenerateToken(null);

        return Ok(token);
    }
}