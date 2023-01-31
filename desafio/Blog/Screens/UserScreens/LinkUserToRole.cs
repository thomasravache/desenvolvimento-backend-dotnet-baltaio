using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class LinkUserToRole
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular usuário a um perfil");
            Console.WriteLine("---------------");

            Console.Write("Informe o Id do usuário que irá vincular o perfil: ");
            var userId = Console.ReadLine();

            Console.Write($"Informe o Id do perfil que será vinculado ao usuário de Id {userId}: ");
            var roleId = Console.ReadLine();

            Create(new UserRole
            {
                UserId = int.Parse(userId!),
                RoleId = int.Parse(roleId!),
            });

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(UserRole userRole)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection);
                repository.Create(userRole);

                Console.WriteLine("Usuário vinculado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível fazer o vínculo de usuário com perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}