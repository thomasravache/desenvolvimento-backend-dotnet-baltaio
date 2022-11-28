using System.Globalization;

namespace Datas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var timeSpan = new TimeSpan(); // retorna uma fração de tempo
      Console.WriteLine(timeSpan);

      var timeSpanNanoSegundos = new TimeSpan(1);
      Console.WriteLine(timeSpanNanoSegundos);

      var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
      Console.WriteLine(timeSpanHoraMinutoSegundo);

      var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

      var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 40, 10, 20);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

      // TimeSpans são utilizados para cálculos de hora, como controle de ponto de funcionários e etc

      Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
    }
  }
}