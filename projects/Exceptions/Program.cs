namespace Exceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      var arr = new int[3];

      try
      {
        for (var i = 0; i < 10; i++)
        {
          Console.WriteLine(arr[i]);
        }
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