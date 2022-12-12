using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      var pessoaA = new Pessoa("Thomas", 1);
      var pessoaB = new Pessoa("Thomas", 1);

      Console.WriteLine(pessoaA == pessoaB); // false pois os objetos são do tipo referência e não do tipo valor

      Console.WriteLine(pessoaA.Equals(pessoaB));
    }
  }

  public class Pessoa : IEquatable<Pessoa>
  {
    public Pessoa(string nome, int id)
    {
      Id = id;
      Nome = nome;
    }

    public int Id { get; set; }
    public string Nome { get; set; }

    public bool Equals(Pessoa? other)
    {
      return Id == other.Id;
    }
  }
}