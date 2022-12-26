using System;
using BaltaDataAccess.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BaltaDataAccess
{
  class Program
  {
    static void Main(string[] args)
    {
      const string connectionString = "Server=127.0.0.1,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$";

      var category = new Category();
      category.Id = Guid.NewGuid();
      category.Title = "Amazon AWS";
      category.Url = "amazon";
      category.Description = "Categoria destinada a serviços do AWS";
      category.Order = 8;
      category.Summary = "AWS Cloud";
      category.Featured = false;

      var insertSql = @"INSERT INTO
          [Category]
        VALUES(
          id,
          title,
          url,
          summary,
          order,
          description,
          featured)";

      using (var connection = new SqlConnection(connectionString)) // objeto de conexão
      {
        var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");

        foreach (var item in categories)
        {
          Console.WriteLine($"{category.Id} - {category.Title}");
        }
      }
    }
  }
}