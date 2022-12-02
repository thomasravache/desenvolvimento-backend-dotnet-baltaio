using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      var pagamentoBoleto = new PagamentoBoleto();

      pagamentoBoleto.Pagar();
      pagamentoBoleto.Vencimento = DateTime.Now;
      var dataString = pagamentoBoleto.ToString();
    }
  }

  // classe base
  class Pagamento
  {
    // Propriedades
    public DateTime Vencimento;

    // Métodos

    // virtual permite que o metodo seja sobrescrito
    public virtual void Pagar()
    {

    }

    // método base do System
    public override string ToString()
    {
      return Vencimento.ToString("dd/MM/yyyy");
    }
  }

  class PagamentoBoleto : Pagamento
  {
    public string NumeroBoleto;

    public override void Pagar()
    {
      // Regra de pagamento do boleto
    }
  }

  class PagamentoCartaoCredito : Pagamento
  {
    public string NumeroCartaoCredito;

    public override void Pagar()
    {
      // Regra de pagamento do cartão de crédito
    }
  }
}