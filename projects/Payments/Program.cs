using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
        Só um pagamento é muito abstrato, não existe só um pagamento generico
        e sim um pagamento via cartão de crédito, via boleto e etc...
        por isso que a classe abstract faz sentido nesse cenário, não permitindo que
        a classe Pagamento seja instanciada, porém tendo suas implementações base
      */
      var pagamento = new Pagamento(); // erro
    }

    public abstract class Pagamento : IPagamento // classe que implementa o contrato IPagamento
    {
      public DateTime Vencimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

      public virtual void Pagar(double valor)
      {
        throw new NotImplementedException();
      }
    }

    public class PagamentoCartaoCredito : Pagamento
    {
      public override void Pagar(double valor)
      {
        base.Pagar(valor);
      }
    }

    public class PagamentoBoleto : Pagamento
    {
      public override void Pagar(double valor)
      {
        base.Pagar(valor);
      }
    }

    public class PagamentoApplePay : Pagamento
    {
      public override void Pagar(double valor)
      {
        base.Pagar(valor);
      }
    }

    public interface IPagamento
    {
      DateTime Vencimento { get; set; } // precisa de uma propriedade Vencimento

      void Pagar(double valor);
    }
  }
}