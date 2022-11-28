namespace Datas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var data = DateTime.Now;

      if (data.Date == DateTime.Now.Date) // comparando somente as datas
      {
        Console.WriteLine("é igual");
      }

      // todas as comparações do .net também valem para datas
      // Datas são value types

      Console.WriteLine(data);
    }
  }
}