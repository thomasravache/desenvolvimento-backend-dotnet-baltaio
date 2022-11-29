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

      for (var index = 0; index < meuArray.Length; index++)
      {
        Console.WriteLine(meuArray[index]);
      }
    }
  }
}