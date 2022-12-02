using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {

    }
  }

  // classe base
  public class Pagamento
  {
    // Propriedades
    public DateTime Vencimento { get; set; }
    private DateTime _dataPagamento; // _ para variáveis privadas
    public DateTime DataPagamento
    {
      get
      { 
        Console.WriteLine("Lendo valor");
        return _dataPagamento;
      }
      set
      {
        Console.WriteLine("Atribuindo valor");
        _dataPagamento = value;
      }
    }


    // Métodos
    void Pagar()
    {

    }
  }
}