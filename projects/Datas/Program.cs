using System.Globalization;

namespace Datas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      // Localização e globalização
        // tipos de cultura

      var br = new CultureInfo("pt-BR");
      var pt = new CultureInfo("pt-PT");
      var en = new CultureInfo("en-US");
      var de = new CultureInfo("de-DE");
      var atual = CultureInfo.CurrentCulture; // cultura atual da sua máquina.

      Console.WriteLine(DateTime.Now.ToString("D", br));
    }
  }
}