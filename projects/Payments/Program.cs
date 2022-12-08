using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {

    }

    public class PagamentoCartaoCredito : IPagamento
    {
      public DateTime Vencimento { get; set; }

      public void Pagar(double valor)
      {
        throw new NotImplementedException();
      }
    }

    public class Pagamento : IPagamento // classe que implementa o contrato IPagamento
    {
      public DateTime Vencimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

      public void Pagar(double valor)
      {
        throw new NotImplementedException();
      }
    }

    public interface IPagamento
    {
      DateTime Vencimento { get; set; } // precisa de uma propriedade Vencimento

      void Pagar(double valor);
    }
  }
}