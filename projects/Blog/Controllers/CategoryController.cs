using Blog.Data;
using Blog.Extensions;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("v1/categories")]
        public async Task<IActionResult> GetAsync(
            [FromServices] BlogDataContext context
        )
        {
            try
            {
                var categories = await context.Categories.AsNoTracking().ToListAsync();

                return Ok(new ResultViewModel<List<Category>>(categories));
            }
            catch
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ResultViewModel<List<Category>>("05XE1 - Falha interna no servidor")
                    );
            }
        }

        [HttpGet("v1/categories/{id:int}")] // dá pra tipar os parâmetros de rota
        public async Task<IActionResult> GetByIdAsync(
            [FromRoute] int id,
            [FromServices] BlogDataContext context
        )
        {
            try
            {
                var category = await context.Categories
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (category == null)
                    return NotFound(new ResultViewModel<Category>("Conteúdo não encontrado"));

                return Ok(new ResultViewModel<Category>(category));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultViewModel<Category>("05XE2 - Falha interna no servidor"));
            }
        }

        [HttpPost("v1/categories")] // dá pra tipar os parâmetros de rota
        public async Task<IActionResult> PostAsync(
            [FromBody] EditorCategoryViewModel model,
            [FromServices] BlogDataContext context
        )
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResultViewModel<Category>(ModelState.GetErrors()));

            try
            {
                var category = new Category
                {
                    Name = model.Name,
                    Slug = model.Slug
                };

                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();

                return Created($"v1/categories/{category.Id}", new ResultViewModel<Category>(category));
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultViewModel<Category>("05XE9 - Não foi possível incluir a categoria"));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultViewModel<Category>("05XE10 - Falha interna no servidor"));
            }
        }

        [HttpPut("v1/categories/{id:int}")] // dá pra tipar os parâmetros de rota
        public async Task<IActionResult> PutAsync(
            [FromRoute] int id,
            [FromBody] EditorCategoryViewModel model,
            [FromServices] BlogDataContext context
        )
        {
            try
            {

                var category = await context.Categories
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (category == null)
                    return NotFound(new ResultViewModel<Category>("Conteúdo não encontrado"));

                category.Name = model.Name;
                category.Slug = model.Slug;

                context.Categories.Update(category);
                await context.SaveChangesAsync();

                return Ok(new ResultViewModel<Category>(category));
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultViewModel<Category>("05XE8 - Não foi possível alterar a categoria"));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultViewModel<Category>("05XE11 - Falha interna no servidor"));
            }
        }

        [HttpDelete("v1/categories/{id:int}")] // dá pra tipar os parâmetros de rota
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] int id,
            [FromServices] BlogDataContext context
        )
        {
            try
            {
                var category = await context.Categories
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (category == null)
                    return NotFound(new ResultViewModel<Category>("Conteúdo não encontrado"));

                context.Categories.Remove(category);
                await context.SaveChangesAsync();

                return Ok(new ResultViewModel<Category>(category));
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultViewModel<Category>("05XE7 - Não foi possível excluir a categoria"));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultViewModel<Category>("05XE12 - Falha interna no servidor"));
            }
        }
    }
}