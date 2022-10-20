using System;

namespace Strings
{
  public static class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";

      Console.WriteLine(texto.ToLower()); // converte pra minúsculo
      Console.WriteLine(texto.ToUpper());

      Console.WriteLine(texto.Insert(5, "AQUI ")); // coloca na posição 5 do array a palavra "AQUI "
      Console.WriteLine(texto.Remove(5, 5)); // remove valores, no caso do indice 5, removendo 5 elementos

      Console.WriteLine(texto.Length); // Quantidade de letras que um texto possui
    }
  }
}