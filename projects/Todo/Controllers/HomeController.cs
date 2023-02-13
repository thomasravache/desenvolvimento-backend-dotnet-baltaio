using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todo.Data;
using Todo.Models;

namespace Todo.Controllers
{
    [ApiController]
    // [Route("[controller]")] // prefixo de rota (mesmo que escrever "Home")
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get(
            [FromServices] AppDbContext context // Adquirir o contexto por injeção de dependências
        )
        => Ok(context.Todos.AsNoTracking().ToList());

        [HttpGet("/{id:int}")]
        public IActionResult GetById(
            [FromServices] AppDbContext context, // Adquirir o contexto por injeção de dependências
            [FromRoute] int id
        )
        {
            var todos = context.Todos.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if (todos == null)
                return NotFound();

            return Ok(todos);
        }

        [HttpPost("/")] // ou [HttpGet("/rota")]
        public IActionResult Post(
            [FromServices] AppDbContext context, // Adquirir o contexto por injeção de dependências
            [FromBody] TodoModel todo
        )
        {
            context.Todos.Add(todo);
            context.SaveChanges();

            return Created($"/{todo.Id}", todo);
        }

        [HttpPut("/{id:int}")] // ou [HttpGet("/rota")]
        public IActionResult Put(
            [FromRoute] int id,
            [FromBody] TodoModel todo,
            [FromServices] AppDbContext context // Adquirir o contexto por injeção de dependências
        )
        {
            var model = context.Todos.FirstOrDefault(x => x.Id == id);

            if (model == null)
                return NotFound();

            model.Title = todo.Title;
            model.Done = todo.Done;

            context.Todos.Update(model);
            context.SaveChanges();

            return Ok(model);
        }

        [HttpDelete("/{id:int}")] // ou [HttpGet("/rota")]
        public IActionResult Delete(
            [FromRoute] int id,
            [FromBody] TodoModel todo,
            [FromServices] AppDbContext context // Adquirir o contexto por injeção de dependências
        )
        {
            var model = context.Todos.FirstOrDefault(x => x.Id == id);

            if (model == null)
                return NotFound();

            context.Todos.Remove(model);
            context.SaveChanges();

            return Ok(model);
        }
    }
}