using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controllers
{
    [ApiController]
    // [Route("[controller]")] // prefixo de rota (mesmo que escrever "Home")
    public class HomeController : ControllerBase
    {
        [HttpGet("/")] // ou [HttpGet("/rota")]
        public List<TodoModel> Get(
            [FromServices] AppDbContext context // Adquirir o contexto por injeção de dependências
        )
        {
            return context.Todos.ToList();
        }

        [HttpPost("/")] // ou [HttpGet("/rota")]
        public TodoModel Post(
            [FromServices] AppDbContext context, // Adquirir o contexto por injeção de dependências
            [FromBody] TodoModel todo
        )
        {
            context.Todos.Add(todo);
            context.SaveChanges();

            return todo;
        }
    }
}