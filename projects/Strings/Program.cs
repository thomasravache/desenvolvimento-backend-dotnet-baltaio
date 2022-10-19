using System;

namespace Strings
{
  public static class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";
      var numero = 10;

      numero.Equals(5);
      numero.Equals(10);
      Console.WriteLine(texto.Equals("Este texto é um teste"));
      Console.WriteLine(texto.Equals("este texto é um teste"));
      Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
    }
  }
}