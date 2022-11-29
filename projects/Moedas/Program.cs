using System;
using System.Globalization;

namespace Moedas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      decimal valor = 10526.25m;

      Console.WriteLine(Math.Round(valor)); // arredondar
      Console.WriteLine(Math.Ceiling(valor)); // arredonda pra cima
      Console.WriteLine(Math.Floor(valor)); // arredonda pra baixo
    }
  }
}