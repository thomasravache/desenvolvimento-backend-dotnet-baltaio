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
                Task faz o processamento paralelo
                entre as chamadas assíncronas (chamada a um serviço, banco, etc..)
            */
            using var context = new BlogDataContext();

            /*
                Esse método não vai esperar finalizar a consulta do banco pra
                prosseguir com o método inteiro, pois fará a busca assíncronamente

                Será feita a criação de threads pra cada método assíncrono, que ficarão
                em uma espécie de fila e quando tudo estiver pronto será retornado
            */
            var post = await context.Posts.ToListAsync(); // Método assíncrono
            var posts2 = await context.Posts.ToListAsync();

            var posts = await GetPosts(context);

            Console.WriteLine("Teste");
        }

        public static async Task<IEnumerable<Post>> GetPosts(BlogDataContext context)
        {
            return await context.Posts.ToListAsync();
        }
    }
}