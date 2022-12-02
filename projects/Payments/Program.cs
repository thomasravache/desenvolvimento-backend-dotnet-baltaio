using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      var pagamentoBoleto = new PagamentoBoleto();

      pagamentoBoleto.Pagar(); // pode acessar pois método com classe base protected
      pagamentoBoleto.Vencimento = DateTime.Now; // erro para acessar pois é privado
    }
  }

  // classe base
  public class Pagamento
  {
    // Propriedades
    private DateTime Vencimento;

    // Métodos

    // virtual permite que o metodo seja sobrescrito
    protected virtual void Pagar()
    {

    }
  }

  public class PagamentoBoleto : Pagamento
  {
    void Test()
    {
      // acessar métodos do pai
      base.Pagar();
    }
  }
}