using System;

namespace Strings
{
  public static class Program
  {
    static void Main(string[] args)
    {
      // var texto = "Testando";

      // Console.WriteLine(texto.CompareTo("Testando")); // 0 => compara textos iguais

      var texto = "Esse texto contém um teste";

      Console.WriteLine(texto.Contains("Teste"));
      Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // ignorar case sensitive
      Console.WriteLine(texto.Contains(null)); // erro
    }
  }
}