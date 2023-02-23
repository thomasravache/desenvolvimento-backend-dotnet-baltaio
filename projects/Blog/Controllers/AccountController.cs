using Blog.Services;
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

    // [AllowAnonymous] // Permite que seja feita a requisição sem passar token
    [HttpPost("v1/login")]
    public IActionResult Login()
    {
        // var tokenService = new TokenService();
        var token = _tokenService.GenerateToken(null);

        return Ok(token);
    }

    [Authorize(Roles = "user")]
    [HttpGet("v1/user")]
    public IActionResult GetUser() => Ok(User.Identity.Name);

    [Authorize(Roles = "author")]
    [HttpGet("v1/author")]
    public IActionResult GetAuthor() => Ok(User.Identity.Name);

    [Authorize(Roles = "admin")]
    [HttpGet("v1/admin")]
    public IActionResult GetAdmin() => Ok(User.Identity.Name);
}