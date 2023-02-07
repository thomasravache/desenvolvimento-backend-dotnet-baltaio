using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            var user = new User
            {
                Bio = "Cara legal",
                Email = "thomassantos@gmail.com",
                Image = "https://minhaimagem",
                Name = "Thomão da Massa",
                PasswordHash = "1212121",
                Slug = "thomao-da-massa",
                GitHub = "github.com"
            };

            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}