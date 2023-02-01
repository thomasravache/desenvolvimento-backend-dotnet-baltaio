using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostTagScreens
{
    public static class LinkPostToTag
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular post a uma tag");
            Console.WriteLine("---------------");

            Console.Write("Informe o Id do post que irá vincular a tag: ");
            var postId = Console.ReadLine();

            Console.Write($"Informe o Id da tag que será vinculado ao post de Id {postId}: ");
            var tagId = Console.ReadLine();

            Create(new PostTag
            {
                PostId = int.Parse(postId!),
                TagId = int.Parse(tagId!),
            });

            Console.ReadKey();
            MenuPostTagScreen.Load();
        }

        public static void Create(PostTag postTag)
        {
            try
            {
                var repository = new Repository<PostTag>(Database.Connection);
                repository.Create(postTag);

                Console.WriteLine("Post vinculado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível fazer o vínculo de post com tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}