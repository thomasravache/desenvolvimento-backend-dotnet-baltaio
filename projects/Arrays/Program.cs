namespace Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      // arrays são reference types então na atribuição de um em outro não é uma cópia e sim um apontamento na memória
      var arr1 = new int[4];
      var arr2 = arr1;

      arr2[0] = arr1[0]; // aqui sim funciona pois é uma cópia de uma propriedade de um pra outro
      arr1.CopyTo(arr2, 0);

      arr1[0] = 23;

      Console.WriteLine(arr2[0]);
    }
  }
}