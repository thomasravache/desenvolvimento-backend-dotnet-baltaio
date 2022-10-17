using System;

namespace Strings
{
  public static class Program
  {
    static void Main(string[] args)
    {
      // interpolação de strings

      var price = 10.2;

      // var texto = "O preço do produto é " + price + " apenas na promoção";

      // var texto = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true);

      var texto = $"O preço do produto é ${price} apenas na promoção";

      // pulando linhas no cóigo
      var texto = $@"O preço do produto é ${price}
        apenas na promoção";

      Console.WriteLine(texto);
    }
  }
}