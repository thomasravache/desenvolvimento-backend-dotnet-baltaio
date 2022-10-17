using System;

namespace Strings
{
  public static class Program
  {
    static void Main(string[] args)
    {
      var id = Guid.NewGuid();
      // convertendo Guid pra string
      id.ToString();

      // id = new Guid("") -> passar um guid valido para gerar um guid
      Console.WriteLine(id);
    }
  }
}