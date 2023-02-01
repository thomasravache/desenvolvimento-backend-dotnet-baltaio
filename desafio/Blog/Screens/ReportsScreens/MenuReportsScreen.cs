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
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListCategoryWithPostCount();
                    break;
                default:
                    Load(); break;
            }
        }

        private static void ListCategoryWithPostCount()
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
    }
}