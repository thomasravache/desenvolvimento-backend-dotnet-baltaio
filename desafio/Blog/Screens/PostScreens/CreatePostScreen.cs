using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo post");
            Console.WriteLine("-------------");

            Console.Write("Id da categoria: ");
            var categoryId = Console.ReadLine();

            Console.Write("Id do autor: ");
            var authorId = Console.ReadLine();

            Console.Write("Title: ");
            var title = Console.ReadLine();

            Console.Write("Summary: ");
            var summary = Console.ReadLine();

            Console.Write("Body: ");
            var body = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Post
            {
                CategoryId = int.Parse(categoryId!),
                AuthorId = int.Parse(authorId!),
                Title = title!,
                Summary = summary!,
                Body = body!,
                Slug = slug!,
            });

            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);

                Console.WriteLine("Post criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}