namespace Datas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var dataEspecifica = new DateTime(2020, 10, 12, 8, 23, 14);

      Console.WriteLine(dataEspecifica);
      Console.WriteLine(dataEspecifica.Year);
      Console.WriteLine(dataEspecifica.Month);
      Console.WriteLine(dataEspecifica.Hour);
      Console.WriteLine(dataEspecifica.Minute);
      Console.WriteLine(dataEspecifica.Second);
      Console.WriteLine(dataEspecifica.DayOfWeek);
      Console.WriteLine((int)dataEspecifica.DayOfWeek);
    }
  }
}