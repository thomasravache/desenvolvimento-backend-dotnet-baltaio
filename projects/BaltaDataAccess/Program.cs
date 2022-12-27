using System;
using System.Data;
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

      using (var connection = new SqlConnection(connectionString)) // objeto de conexão
      {
        // ListCategories(connection);
        // CreateCategory(connection);
        // UpdateCategory(connection);
        // CreateManyCategory(connection);
        // ExecuteProcedure(connection);
        // ExecuteReadProcedure(connection);
        // ExecuteScalar(connection);
        ReadView(connection);
      }
    }

    static void ListCategories(SqlConnection connection)
    {
      var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");

      foreach (var item in categories)
      {
        Console.WriteLine($"{item.Id} - {item.Title}");
      }
    }

    static void CreateCategory(SqlConnection connection)
    {
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
          @Id,
          @Title,
          @Url,
          @Summary,
          @Order,
          @Description,
          @Featured)";

      // Utilizar o .Execute para Insert, Update, Delete
      var rows = connection.Execute(insertSql, new
      {
        category.Id,
        category.Title,
        category.Url,
        category.Summary,
        category.Order,
        category.Description,
        category.Featured
      }); // passando valores por parâmetro pra evitar SQL Injection

      Console.WriteLine($"{rows} linhas inseridas");
    }

    static void CreateManyCategory(SqlConnection connection)
    {
      var category = new Category();
      category.Id = Guid.NewGuid();
      category.Title = "Amazon AWS";
      category.Url = "amazon";
      category.Description = "Categoria destinada a serviços do AWS";
      category.Order = 8;
      category.Summary = "AWS Cloud";
      category.Featured = false;

      var category2 = new Category();
      category2.Id = Guid.NewGuid();
      category2.Title = "categoria nova";
      category2.Url = "categoria-nova";
      category2.Description = "Categoria nova";
      category2.Order = 9;
      category2.Summary = "Nova";
      category2.Featured = true;

      var insertSql = @"INSERT INTO
          [Category]
        VALUES(
          @Id,
          @Title,
          @Url,
          @Summary,
          @Order,
          @Description,
          @Featured)";

      // Utilizar o .Execute para Insert, Update, Delete
      var rows = connection.Execute(insertSql, new[]
      {
        new {
          category.Id,
          category.Title,
          category.Url,
          category.Summary,
          category.Order,
          category.Description,
          category.Featured

        },
        new {
          category2.Id,
          category2.Title,
          category2.Url,
          category2.Summary,
          category2.Order,
          category2.Description,
          category2.Featured
        }
      }); // passando valores por parâmetro pra evitar SQL Injection

      Console.WriteLine($"{rows} linhas inseridas");
    }

    static void UpdateCategory(SqlConnection connection)
    {
      var updateQuery = "UPDATE [Category] SET [Title]=@title WHERE [Id]=@id";

      var rows = connection.Execute(updateQuery, new
      {
        id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
        title = "Frontend 2021"
      });

      Console.WriteLine($"{rows} registros atualizados");
    }

    static void ExecuteProcedure(SqlConnection connection)
    {
      var procedure = "spDeleteStudent";

      var pars = new
      {
        StudentId = "2d4c3303-b8a2-4e87-83b3-93b613de317e",
      };

      var affectedRows = connection.Execute(procedure, pars, commandType: CommandType.StoredProcedure);

      Console.WriteLine($"{affectedRows} linhas afetadas");
    }

    static void ExecuteReadProcedure(SqlConnection connection)
    {
      var procedure = "spGetCoursesByCategory";

      var pars = new
      {
        CategoryId = "09ce0b7b-cfca-497b-92c0-3290ad9d5142",
      };

      // Retorna um IEnumerable de dynamic, não precisa tipar, mas se quiser é uma boa prática
      // Se houver algum erro só dará pra ver em tempo de execução e não de compilação
      var courses = connection.Query(procedure, pars, commandType: CommandType.StoredProcedure);

      foreach (var item in courses)
      {
        Console.WriteLine(item.Title);
      }
    }

    static void ExecuteScalar(SqlConnection connection)
    {
      var category = new Category();
      category.Title = "Amazon AWS";
      category.Url = "amazon";
      category.Description = "Categoria destinada a serviços do AWS";
      category.Order = 8;
      category.Summary = "AWS Cloud";
      category.Featured = false;

      var insertSql = @"
        INSERT INTO
          [Category]
        OUTPUT inserted.[Id]
        VALUES(
          NEWID(),
          @Title,
          @Url,
          @Summary,
          @Order,
          @Description,
          @Featured)";

      // Utilizar o .Execute para Insert, Update, Delete
      var id = connection.ExecuteScalar<Guid>(insertSql, new
      {
        category.Title,
        category.Url,
        category.Summary,
        category.Order,
        category.Description,
        category.Featured
      }); // passando valores por parâmetro pra evitar SQL Injection

      Console.WriteLine($"A categoria inserida foi: {id}");
    }

    static void ReadView(SqlConnection connection)
    {
      var sql = "SELECT * FROM [vwCourses]";

      var courses = connection.Query(sql);

      foreach (var item in courses)
      {
        Console.WriteLine(item.Title);
      }
    }
  }
}