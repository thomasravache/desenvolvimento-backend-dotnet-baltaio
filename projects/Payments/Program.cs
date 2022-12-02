using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      var customer = new Customer();
      customer.name = "teste";

      Console.WriteLine("Hello World");
    }
  }

  class Pagamento
  {
    // Propriedades
    DateTime Vencimento;

    // Métodos
    void Pagar()
    {

    }
  }
}