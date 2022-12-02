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
    DateTime Vencimento;
    Address BillingAdress;

    // Métodos
    void Pagar()
    {

    }
  }

  public class Address
  {
    public string ZipCode;
  }
}