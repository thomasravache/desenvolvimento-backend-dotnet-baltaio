using System;
using System.Text;

namespace Strings
{
  public static class Program
  {
    static void Main(string[] args)
    {
      // utilizar se tiver uma string muito grande para ir inserindo informações
      var texto2 = new StringBuilder();

      texto2.Append("texto legal");
      texto2.Append("texto legal 2");
      texto2.Append("texto legal 3");

      texto2.ToString();
      Console.WriteLine(texto2);
    }
  }
}