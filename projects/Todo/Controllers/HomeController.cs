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
        public List<TodoModel> Get(
            [FromServices] AppDbContext context // Adquirir o contexto por injeção de dependências
        )
        {
            return context.Todos.AsNoTracking().ToList();
        }

        [HttpGet("/{id:int}")]
        public TodoModel GetById(
            [FromServices] AppDbContext context, // Adquirir o contexto por injeção de dependências
            [FromRoute] int id
        )
        {
            return context.Todos.AsNoTracking().FirstOrDefault(x => x.Id == id);
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

        [HttpPut("/{id:int}")] // ou [HttpGet("/rota")]
        public TodoModel Put(
            [FromRoute] int id,
            [FromBody] TodoModel todo,
            [FromServices] AppDbContext context // Adquirir o contexto por injeção de dependências
        )
        {
            var model = context.Todos.FirstOrDefault(x => x.Id == id);

            if (model == null)
                return todo;

            model.Title = todo.Title;
            model.Done = todo.Done;

            context.Todos.Update(model);
            context.SaveChanges();

            return model;
        }

        [HttpDelete("/{id:int}")] // ou [HttpGet("/rota")]
        public TodoModel Delete(
            [FromRoute] int id,
            [FromBody] TodoModel todo,
            [FromServices] AppDbContext context // Adquirir o contexto por injeção de dependências
        )
        {
            var model = context.Todos.FirstOrDefault(x => x.Id == id);

            context.Todos.Remove(model);
            context.SaveChanges();

            return model;
        }
    }
}