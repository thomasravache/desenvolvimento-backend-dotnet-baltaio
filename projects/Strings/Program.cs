using System;

namespace Strings
{
  public static class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";

      Console.WriteLine(texto.StartsWith("Este"));
      Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
      Console.WriteLine(texto.StartsWith("texto"));

      Console.WriteLine(texto.EndsWith("teste"));
      Console.WriteLine(texto.EndsWith("Teste"));
      Console.WriteLine(texto.EndsWith("xpro"));
    }
  }
}