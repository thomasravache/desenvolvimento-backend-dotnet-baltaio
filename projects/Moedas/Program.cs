using System;
using System.Globalization;

namespace Moedas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      // Geralmente se usa decimal para armazenar moedas

      decimal valor = 10526.25m;

      Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));
      Console.WriteLine(String.Format("R$ {0}", valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR"))));

      // Formatando como moeda ou número
      Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR"))); // número
      Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // moeda
      Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR"))); // formata como moeda sem R$
      Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR"))); // porcentagem
      Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR")));
      Console.WriteLine(valor.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR")));
    }
  }
}