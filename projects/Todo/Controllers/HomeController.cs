using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controllers
{
    [ApiController]
    [Route("[controller]")] // prefixo de rota (mesmo que escrever "Home")
    public class HomeController : ControllerBase
    {
        [HttpGet] // ou [HttpGet("/rota")]
        [Route("[action]")] // mesmo que escrever "Get"
        public List<TodoModel> Get(
            [FromServices] AppDbContext context // Adquirir o contexto por injeção de dependências
        )
        {
            return context.Todos.ToList();
        }
    }
}