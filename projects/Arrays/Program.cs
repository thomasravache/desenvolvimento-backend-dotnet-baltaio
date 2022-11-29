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

      var meuArray2 = new Teste[2]{ new Teste(), new Teste() };

      Console.WriteLine(meuArray[0]);
    }

    struct Teste
    {
      public int Id { get; set; }
    }
  }
}