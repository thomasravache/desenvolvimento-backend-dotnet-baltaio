using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      IList<Payment> payments = new List<Payment>();
      payments.Add(new Payment());
      payments.Remove(new Payment());
    }
  }

  public class Payment
  {

  }
}