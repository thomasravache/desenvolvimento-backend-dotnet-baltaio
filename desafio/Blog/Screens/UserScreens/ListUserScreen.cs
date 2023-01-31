using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("------------");

            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void List()
        {
            var repository = new UserRepository(Database.Connection);

            var usersWithRoles = repository.GetWithRoles();

            foreach (var user in usersWithRoles)
            {
                string roles = "";

                foreach (var role in user.Roles)
                {
                    roles += $"{role.Name}, ";
                }

                Console.WriteLine($"{user.Name} - {user.Email} - ({roles})");
            }
        }
    }
}