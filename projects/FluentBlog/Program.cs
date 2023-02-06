using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // context.Users.Add(new User
            // {
            //     Bio = "Cara legal",
            //     Email = "thomassantos@gmail.com",
            //     Image = "https://minhaimagem",
            //     Name = "Thomão da Massa",
            //     PasswordHash = "1212121",
            //     Slug = "thomao-da-massa",
            // });

            var user = context.Users.FirstOrDefault();

            var post = new Post
            {
                Author = user,
                Body = "Meu Artigo",
                Category = new Category
                {
                    Name = "Backend",
                    Slug = "back-end",
                },
                CreateDate = System.DateTime.Now,
                Slug = "meu-artigo",
                Summary = "Neste artigo vamos conferir...",
                Title = "Meu artigo",
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}