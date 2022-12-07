using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      var pagamento = new Payment();
      pagamento.PropriedadeCartaoCredito = 1;
      pagamento.PropriedadePagamento = 2;
    }
  }
}