using System.Globalization;

namespace Datas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      // Se preocupar com a hospedagem de sua aplicação pois isso implicará na hora mostrada para o usuário também

      var utcDate = DateTime.UtcNow;

      Console.WriteLine(DateTime.Now); // hora do servidor
      Console.WriteLine(utcDate); // hora universal - recomendado para aplicações globalizadas (utilizada por diversos usuários no mundo)

      // após utilizar a hora universal, mandar para cada usuário de acordo com o seu CultureInfo

      Console.WriteLine(utcDate.ToLocalTime()); // usando horário da máquina

      // se maquina estiver em um lugar e o usuário estiver em outro

      var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
      Console.WriteLine(timezoneAustralia);

      var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
      Console.WriteLine(horaAustralia);

      // --- Listar Timezones ---

      var timezones = TimeZoneInfo.GetSystemTimeZones();

      foreach (var timezone in timezones)
      {
        Console.WriteLine(timezone.Id);
        Console.WriteLine(timezone);
        Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
        Console.WriteLine("_________");
      }
    }
  }
}