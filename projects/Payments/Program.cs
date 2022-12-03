using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      var pagamentoCartao = new PagamentoCartao(DateTime.Now);
      pagamentoCartao.Pagar();
    }
  }

  // classe base
  public class Pagamento
  {
    public Pagamento(DateTime vencimento)
    {
      Console.WriteLine("Iniciando pagamento");
      DataPagamento = DateTime.Now;
    }
    // Propriedades
    public DateTime DataPagamento { get; set; }

    // Métodos
    public virtual void Pagar()
    {
      Console.WriteLine("Pagar - classe base");
    }
  }

  public class PagamentoCartao : Pagamento
  {
    public PagamentoCartao(DateTime vencimento) : base(vencimento)
    {
      
    }

    public override void Pagar()
    {
      // instruções da sobrescrita
      Console.WriteLine("Pagar - sobrescrita");

      base.Pagar(); // executa o funcionamento da classe base
    }
  }
}