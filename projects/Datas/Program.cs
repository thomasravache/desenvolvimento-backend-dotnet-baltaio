namespace Datas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var data = DateTime.Now;

      // Y = ano
      // M = mes
      // d = dia
      // h = hora
      // m = minuto
      // s = segundo
      var t = String.Format("{0:t}", data); // t = short Time
      var T = String.Format("{0:T}", data); // T = long Time
      var d = String.Format("{0:d}", data); // d = short Date
      var D = String.Format("{0:D}", data); // D = long date
      var f = String.Format("{0:f}", data); // f = combinação data e hora long
      var g = String.Format("{0:g}", data); // g = combinação data e hora short
      var r = String.Format("{0:r}", data); // r = padrao que muitos sistemas usam
      var R = String.Format("{0:R}", data); // R = padrao que muitos sistemas usam
      var s = String.Format("{0:s}", data); // s = sortble datetime
      var u = String.Format("{0:u}", data); // s = sortble datetime com espaço + datetime

      Console.WriteLine(t);
      Console.WriteLine(T);
      Console.WriteLine(d);
      Console.WriteLine(D);
      Console.WriteLine(f);
      Console.WriteLine(g);
      Console.WriteLine(r);
      Console.WriteLine(R);
      Console.WriteLine(s);
      Console.WriteLine(u);
    }
  }
}