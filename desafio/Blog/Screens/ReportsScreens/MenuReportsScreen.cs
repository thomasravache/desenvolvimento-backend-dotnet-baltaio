using Blog.Repositories;

namespace Blog.Screens.ReportsScreen
{
    public static class MenuReportsScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de relatórios");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar categorias com quantidade de posts");
            Console.WriteLine("2 - Listar tags com quantidade de posts");
            Console.WriteLine("3 - Listar posts através de uma categoria");
            Console.WriteLine("4 - Listar posts com sua categoria");
            Console.WriteLine("5 - Listar posts com suas tags");
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListCategoriesWithPostCount();
                    break;
                case 2:
                    ListTagsWithPostsCount();
                    break;
                case 3:
                    ListPostsByCategoryId();
                    break;
                case 4:
                    ListPostsWithCategory();
                    break;
                case 5:
                    ListPostsWithTags();
                    break;
                default:
                    Load(); break;
            }
        }

        private static void ListCategoriesWithPostCount()
        {
            var repository = new CategoryRepository(Database.Connection);
            var categoriesWithPostsCount = repository.GetWithPostsCount();

            foreach (var item in categoriesWithPostsCount)
            {
                Console.WriteLine($"{item.CategoryTitle} - {item.PostsCount} post(s)");
            }

            Console.ReadKey();
            Load();
        }

        private static void ListTagsWithPostsCount()
        {
            var repository = new TagRepository(Database.Connection);
            var tagsWithPostsCount = repository.GetWithPostsCount();

            foreach (var item in tagsWithPostsCount)
            {
                Console.WriteLine($"{item.TagName} - {item.PostsCount} post(s)");
            }

            Console.ReadKey();
            Load();
        }

        private static void ListPostsByCategoryId()
        {
            Console.Clear();
            Console.Write("Informe o id da categoria: ");
            var categoryId = Console.ReadLine();
            Console.WriteLine();

            var repository = new PostRepository(Database.Connection);
            var posts = repository.GetByCategoryId(int.Parse(categoryId!));

            foreach (var post in posts)
            {
                Console.WriteLine($"{post.Title}");
            }
        }

        private static void ListPostsWithCategory()
        {
            var repository = new PostRepository(Database.Connection);
            var posts = repository.GetWithCategory();

            foreach (var post in posts)
            {
                Console.WriteLine($"- {post.Title} - {post.Category.Name}");
            }
        }

        private static void ListPostsWithTags()
        {
            var repository = new PostRepository(Database.Connection);
            var posts = repository.GetWithTags();

            foreach (var post in posts)
            {
                var tagNames = string.Join(", ", post.Tags.Select(x => x.Name));

                Console.WriteLine($"{post.Title} - ({tagNames})");
            }
        }
    }
}