using System;

namespace Strings
{
  public static class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";

      Console.WriteLine(texto.Replace("Este", "Isto")); // substitui

      var divisao = texto.Split(" "); // cria uma lista de acordo com o separador 

      Console.WriteLine(divisao[0]);
      Console.WriteLine(divisao[1]);
      Console.WriteLine(divisao[2]);

      var resultado = texto.Substring(4, 5);
      var teste2 = texto.Substring(4, texto.LastIndexOf("e"));

      Console.WriteLine(resultado);
      Console.WriteLine(teste2);

      Console.WriteLine(texto.Trim()); // remove espaços do começo e fim das palavras
    }
  }
}