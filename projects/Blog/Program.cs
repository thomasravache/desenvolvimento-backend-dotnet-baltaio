using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    public class Program
    {
        private const string CONNECTION_STRING = @"Server=127.0.0.1,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            // ReadUsers(connection);
            ReadUsersWithRoles(connection);
            // ReadRoles(connection);
            // ReadTags(connection);

            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var items = repository.Get();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void ReadUsersWithRoles(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var items = repository.GetWithRoles();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);

                foreach (var role in item.Roles)
                {
                    Console.WriteLine($" - {role.Name}");
                }
            }
        }

        public static void ReadUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);

            var item = repository.Get(id: 1);

            Console.WriteLine(item.Name);
        }
        public static void CreateUser(SqlConnection connection)
        {
            var user = new User()
            {
                Bio = "Equipe balta.io",
                Email = "thomas.santos@balta.io",
                Image = "https://...",
                Name = "Equipe balta.io",
                PasswordHash = "HASH",
                Slug = "equipe-balta"
            };

            var repository = new Repository<User>(connection);

            repository.Create(user);

            Console.WriteLine("Usuário criado");
        }

        public static void UpdateUser(SqlConnection connection)
        {
            var user = new User()
            {
                Id = 2,
                Bio = "Equipe balta.io EDITADO",
                Email = "thomas.santos@balta.io",
                Image = "https://...",
                Name = "Equipe balta.io Editado",
                PasswordHash = "HASH",
                Slug = "equipe-balta"
            };

            var repository = new Repository<User>(connection);

            repository.Update(user);

            Console.WriteLine("Usuário editado");
        }

        public static void DeleteUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            repository.Delete(id: 1);
        }

        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }

        public static void ReadTags(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }
    }
}