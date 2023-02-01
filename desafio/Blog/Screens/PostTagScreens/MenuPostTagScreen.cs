namespace Blog.Screens.PostTagScreens
{
    public static class MenuPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de posts/tags");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Vincular um post a uma tag");
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    LinkPostToTag.Load();
                    break;
                default:
                    Load(); break;
            }
        }
    }
}