using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var pagamento = new Pagamento())
      {
        Console.WriteLine("Processando o pagamento");
      }
    }
  }

  // classe base
  public class Pagamento : IDisposable
  {
    public Pagamento()
    {
      Console.WriteLine("Iniciando pagamento");
    }

    public void Dispose()
    {
      Console.WriteLine("Finalizando o pagamento");
    }
  }
}