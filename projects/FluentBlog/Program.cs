using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BlogDataContext();

            // Usar com moderação o ThenInclude

            var posts = context.Posts
                .Include(x => x.Author)
                    .ThenInclude(x => x.Roles) // SUBSELECT
                .Include(x => x.Category);

            foreach (var post in posts)
            {
                foreach (var tag in post.Tags)
                {

                }
            }
            Console.WriteLine("Teste");
        }
    }
}