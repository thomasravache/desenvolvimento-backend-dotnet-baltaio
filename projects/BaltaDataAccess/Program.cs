using System;
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
        connection.Open();
        Console.WriteLine("Conectado");

        using (var command = new SqlCommand())
        {
          command.Connection = connection;
          command.CommandType = System.Data.CommandType.Text;
          command.CommandText = "SELECT [Id], [Title] FROM [Category]";

          var reader = command.ExecuteReader(); // ou  ExecutaNonQuery para não leitura (inserção etc...)
          while (reader.Read())
          {
            Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
          }
        }
      }

      // BOA PRÁTICA: conectar no banco, fazer o necessário e fechar a conexão

    }
  }
}