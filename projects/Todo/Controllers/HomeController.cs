using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    [ApiController]
    [Route("[controller]")] // prefixo de rota (mesmo que escrever "Home")
    public class HomeController : ControllerBase
    {
        [HttpGet] // ou [HttpGet("/rota")]
        [Route("[action]")] // mesmo que escrever "Get"
        public string Get()
        {
            return "Hello World!";
        }
    }
}