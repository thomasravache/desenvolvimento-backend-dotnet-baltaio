using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear(); // Limpa a tela

      Console.WriteLine("Primeiro valor: ");
      float valor1 = float.Parse(Console.ReadLine());

      Console.WriteLine(valor1);
    }
  }
}