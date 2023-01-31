using Blog.Models;
using Blog.Repositories;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
  public class Program
  {
    private const string CONNECTION_STRING = @"Server=127.0.0.1,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

    static void Main(string[] args)
    {
      Database.Connection = new SqlConnection(CONNECTION_STRING);

      Database.Connection.Open();

      Load();

      Console.ReadKey();
      Database.Connection.Close();
    }

    private static void Load()
    {
      Console.Clear();
      Console.WriteLine("Meu Blog");
      Console.WriteLine("----------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Gestão de usuário");
      Console.WriteLine("2 - Gestão de perfil");
      Console.WriteLine("3 - Gestão de categoria");
      Console.WriteLine("4 - Gestão de tag");
      Console.WriteLine("5 - Vincular post/tag");
      Console.WriteLine("6 - Relatórios");
      Console.WriteLine();
      Console.WriteLine();

      var option = short.Parse(Console.ReadLine()!);

      switch (option)
      {
        case 1:
          MenuUserScreen.Load();
          break;
        case 2:
          MenuRoleScreen.Load();
          break;
        // case 3:
        //     MenuCategoryScreen.Load();
        //     break;
        case 4:
          MenuTagScreen.Load();
          break;
        // case 5:
        //     MenuPostTagScreen.Load();
        //     break;
        // case 6:
        //     MenuReportsScreen.Load();
        //     break;
        default: Load(); break;
      }
    }
  }
}