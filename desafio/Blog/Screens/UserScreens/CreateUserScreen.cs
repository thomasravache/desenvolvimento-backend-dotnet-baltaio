using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo usuário");
            Console.WriteLine("--------------");

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("E-mail: ");
            var email = Console.ReadLine();

            Console.Write("Senha: ");
            var senha = Console.ReadLine();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Console.Write("Imagem: ");
            var imagem = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = nome,
                Email = email,
                PasswordHash = senha,
                Bio = bio,
                Image = imagem,
                Slug = slug,
            });

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);

                Console.WriteLine("Usuário criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}