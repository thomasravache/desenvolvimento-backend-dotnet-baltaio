using Blog.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok();

        [HttpGet("v1/auth-by-api-key")]
        [ApiKey]
        public IActionResult AuthByApiKey() => Ok();

    }
}