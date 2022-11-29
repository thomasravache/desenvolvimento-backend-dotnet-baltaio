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
        for (var i = 0; i < 10; i++)
        {
          Console.WriteLine(arr[i]);
        }
      }
      catch(IndexOutOfRangeException ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.InnerException);
        Console.WriteLine("Não encontrei o índice");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Ops... Algo deu errado");
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.InnerException);
      }
    }
  }
}