using System.Globalization;

namespace Datas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      Console.WriteLine(DateTime.DaysInMonth(2020, 2)); // mostra a quantidade de dias que tem em um mês
      
      // verificar se é fim de semana
      Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

      // verificar se estamos ou não em horário de verão
      Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
    }

    static bool IsWeekend(DayOfWeek today)
    {
      return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
    }
  }
}