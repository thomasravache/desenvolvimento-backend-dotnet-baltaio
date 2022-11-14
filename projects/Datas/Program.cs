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
      // var formatada = String.Format("{0:yyyy}", data); // ano
      // var formatada = String.Format("{0:yyyy-MM-dd}", data); //
      var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data); // ff e zz para fração de segundo e timezone
      Console.WriteLine(formatada);
    }
  }
}