using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*
                Lazy Loading (NÃO RECOMENDÁVEL):

                    - Carregamento preguiçoso das entidades relacionadas
                    - Precisa colocar método virtual nas entidades relacionadas
                    - Carregamento é feito automático ao pedir um relacionamento
                        Ex: context.Posts.Tags()
                    - Acaba fazendo vários SELECTs para que isso funcione de fato

                Eager Loading (MAIS RECOMENDÁVEL):

                    - Carregamento ansioso
                    - Necessário explicitar no contexto as entidades relacionadas que você quer trazer
                    - Ganho é melhor porque não faz vários SELECTS para trazer as entidades
                    - Utiliza Inner Joins para trazer as entidades relacionadas solicitadas e isso é bem melhor
            */
            using var context = new BlogDataContext();

            // var posts = context.Posts;

            // OUTRA DICA => Sempre utilizar o Select para selecionar apenas o que você precisa
            // var posts = context.Posts.Include(x => x.Tags).Select(x => new { Id = x.Id });

            var posts = context.Posts.Include(x => x.Tags);

            foreach (var post in posts) // SELECT * FROM [Post]
            {
                foreach (var tag in post.Tags) // Vai executar outro select
                {

                }
            }

            Console.WriteLine("Teste");
        }
    }
}