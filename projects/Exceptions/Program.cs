namespace Exceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      var arr = new int[3];

      // Tratar os erros dos mais específicos para os mais genéricos
      try
      {
        // for (var i = 0; i < 10; i++)
        // {
        //   Console.WriteLine(arr[i]);
        // }

        Salvar("");
      }
      catch(IndexOutOfRangeException ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.InnerException);
        Console.WriteLine("Não encontrei o índice");
      }
      catch(ArgumentNullException ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.InnerException);
        Console.WriteLine("Falha ao cadastrar texto");
      }
      catch(MinhaException ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.QuandoAconteceu);
        Console.WriteLine("Exceção customizada");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Ops... Algo deu errado");
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.InnerException);
      }
    }

    private static void Salvar(string texto)
    {
      if (string.IsNullOrEmpty(texto))
        throw new MinhaException(DateTime.Now);
    }
  }

  public class MinhaException : Exception
  {
    public MinhaException(DateTime date)
    {
      QuandoAconteceu = date;
    }

    public DateTime QuandoAconteceu { get; set; }
  }
}