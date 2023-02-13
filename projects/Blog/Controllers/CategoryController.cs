using Blog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("categories")]
        public IActionResult Get(
            [FromServices] BlogDataContext context
        )
        {
            var categories = context.Categories.AsNoTracking().ToList();

            return Ok(categories);
        }
    }
}