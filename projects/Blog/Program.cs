using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet2" };

                // context.Tags.Add(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);

                // if (tag == null)
                //     return;

                // tag.Name = "Ponto NET";
                // tag.Slug = "dotnetzada";

                // context.Update(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1003);

                // context.Remove(tag);
                // context.SaveChanges();

                // var tags = context.Tags; // apenas a referencia
                // var tags = context
                //     .Tags
                //     .AsNoTracking()
                //     .ToList();
                // executa a query no banco nesta linha

                // SEMPRE UTILIZAR O ToList() por último

                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Name);
                // }

                // se não vai atualizar ou remover não utilizar o tracking
                // pontos importantes
                // onde coloca o ToList()
                // utilizar AsNoTracking

                var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 2);

                // Da mesma form que toList executa a query o firstOrDefault também,
                // todos os métodos de lista executam a query

                // FirstOrDefault => pega o primeiro mesmo se trazer mais de um
                // Single / SingleOrDefault => se tiver mais de um resultado dá erro
            }
        }
    }
}