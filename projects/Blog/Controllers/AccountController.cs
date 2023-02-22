using Blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

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

    [HttpPost("v1/login")]
    public IActionResult Login()
    {
        // var tokenService = new TokenService();
        var token = _tokenService.GenerateToken(null);

        return Ok(token);
    }
}