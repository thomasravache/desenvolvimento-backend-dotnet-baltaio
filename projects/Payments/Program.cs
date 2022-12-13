using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      var person = new Person();
      var payment = new Payment();
      var subscription = new Subscription();

      var context = new DataContext<Person, Payment, Subscription>();

      context.Save(person);
      context.Save(payment);
      context.Save(subscription);
    }
  }

  public class DataContext<T, U, V>
    where T : IPerson
    where U : Payment
    where V : Subscription
  {
    public void Save(T entity)
    {

    }

    public void Save(U entity)
    {

    }

    public void Save(V entity)
    {

    }
  }

  public interface IPerson
  {

  }

  public class Person : IPerson
  {

  }

  public class Payment
  {

  }

  public class Subscription
  {

  }
}