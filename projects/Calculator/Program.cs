using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Multiplicação");
      Console.WriteLine("4 - Divisão");
      Console.WriteLine("5 - Sair");

      Console.WriteLine("------------");
      Console.WriteLine("Selecione uma opção:");

      short opcaoSelecionada = short.Parse(Console.ReadLine());

      switch (opcaoSelecionada)
      {
        case 1:
          Soma();
          break;
        case 2:
          Subtracao();
          break;
        case 3:
          Multiplicacao();
          break;
        case 4:
          Divisao();
          break;
        case 5:
          System.Environment.Exit(0);
          break;
        default:
          Menu();
          break;
      }
    }

    static void Soma()
    {
      Console.Clear(); // Limpa a tela
      Console.WriteLine("Soma");

      Console.WriteLine("Primeiro valor: ");
      float valor1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float valor2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = valor1 + valor2;
      Console.WriteLine("O resultado da soma é " + resultado);
      // Console.WriteLine("O resultado da soma é " + (valor1 + valor2));

      Console.WriteLine($"O resultado da some é {resultado} - (exibindo com interpolação)");
      // Console.WriteLine($"O resultado da some é {valor1 + valor2} - (exibindo com interpolação)");

      Console.ReadKey();
      Menu();
    }

    static void Subtracao()
    {
      Console.Clear();
      Console.WriteLine("Subtração");

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine($"O resultado da subtração é {v1 - v2}.");

      Console.ReadKey();
      Menu();
    }

    static void Divisao()
    {
      Console.Clear();
      Console.WriteLine("Divisão");

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      if (v2 == 0)
      {
        Console.WriteLine("Não é possível fazer divisão por zero");
      }
      else
      {
        Console.WriteLine($"O resultado da divisão é {v1 / v2}");
      }

      Console.ReadKey();
      Menu();
    }

    static void Multiplicacao()
    {
      Console.Clear();
      Console.WriteLine("Multiplicação");

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine($"O resultado da multiplicação é {v1 * v2}");

      Console.ReadKey();
      Menu();
    }
  }
}