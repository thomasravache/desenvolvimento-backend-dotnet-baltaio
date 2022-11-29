namespace Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      // array - não muito utilizado
      var meuArray = new int[5]{ 20, 50, 10, 22, 98 }; // array de inteiros ja inicializado
      meuArray[0] = 12;

      // podendo ser feito com structs também e classes e etc
      foreach (var item in meuArray)
      {
        Console.WriteLine(item);
      }
    }
  }
}