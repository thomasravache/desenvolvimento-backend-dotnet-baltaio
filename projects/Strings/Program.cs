using System;

namespace Strings
{
  public static class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";

      // índice = posição -> começando de 0

      // string é um array de caracteres

      Console.WriteLine(texto.IndexOf("é")); // posição 11
      Console.WriteLine(texto.LastIndexOf("s")); // 18
    }
  }
}