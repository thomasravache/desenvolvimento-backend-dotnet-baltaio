using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            var user = new User
            {
                Name = "Thomas Ravache",
                Slug = "thomasravachedossantos",
                Email = "thomasravache@gmail.com",
                Bio = "Dev",
                Image = "https://balta.io",
                PasswordHash = "15515615",
            };

            var category = new Category
            {
                Name = "Backend",
                Slug = "backend"
            };

            /*
                Mesmo não passando o Id da Category e o Author
                pro novo post (abaixo), o EF Core é inteligente o suficiente
                pra identificar o relacionamento entre ele e já fazer o vínculo

                (Utiliza o SCOPE IDENTITY pra fazer esse vínculo)
                Isso tudo é feito de forma transacionada (Se der erro em um, não será feito o insert)

                ||
                ||
                \/
            */
            var post = new Post
            {
                Author = user,
                Category = category,
                Body = "<p>Hello!</p>",
                Slug = "comecando-com-efcore",
                Summary = "Neste artigo vamos aprender EF core",
                Title = "Começando com EF Core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };

            /*
                Não é preciso adicionar o Add do user e da category
                EF já identifica que user e category atrelados ao post são novos usuários
                por conta de serem novas instancias (new User, new Author, etc...)
             */
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}