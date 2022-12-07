using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Pagamento.Vencimento);
    }
  }

  // classe base
  public static class Pagamento
  {
    public static DateTime Vencimento { get; set; }
  }
}