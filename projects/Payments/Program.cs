using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
    }
  }

  // classe base
  public sealed class Pagamento
  {
    public DateTime Vencimento { get; set; }
  }
}