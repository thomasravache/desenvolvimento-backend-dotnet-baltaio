using System;

namespace Payments
{
  class Program
  {
    static void RealizarPagamento(double valor)
    {
      Console.WriteLine($"Pago o valor de {valor}");
    }

    static void Main(string[] args)
    {
      // Delegates => Anonymous Methods
      var pagar = new Pagamento.Pagar(RealizarPagamento); // função que chama uma outra função
      pagar(25);
    }
  }

  public class Pagamento
  {
    public delegate void Pagar(double valor);
  }
}