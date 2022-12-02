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
    }
  }

  // classe base
  class Pagamento
  {
    // Propriedades
    public DateTime Vencimento;

    // Métodos
    public void Pagar()
    {

    }
  }

  class PagamentoBoleto : Pagamento
  {
    public string NumeroBoleto;
  }

  class PagamentoCartaoCredito : Pagamento
  {
    public string NumeroCartaoCredito;
  }
}