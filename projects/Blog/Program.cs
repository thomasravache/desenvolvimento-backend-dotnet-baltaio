using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
  public class Program
  {
    private const string CONNECTION_STRING = @"Server=127.0.0.1,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

    static void Main(string[] args)
    {
      ReadUsers();
    }

    public static void ReadUsers()
    {
      using (var connection = new SqlConnection(CONNECTION_STRING))
      {
        var users = connection.GetAll<User>();

        foreach (var user in users)
        {
          Console.WriteLine(user.Name);
        }
      }
    }
  }
}