namespace EditorHtml
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.Black;

      DrawScreen(10, 30);
      WriteOptions();

      var option = short.Parse(Console.ReadLine());
    }

    public static void DrawScreen(int lines, int columns)
    {
      DrawHeaderOrFooter(columns);
      DrawContent(columns, lines);
      DrawHeaderOrFooter(columns);
    }

    private static void DrawHeaderOrFooter(int columns)
    {
      Console.Write("+");
      for (int column = 1; column <= columns; column++) Console.Write("-");
      Console.Write("+");

      Console.Write("\n");
    }

    private static void DrawContent(int columns, int lines)
    {
      for (int line = 1; line <= lines; line++)
      {
        Console.Write("|");
        for (int column = 1; column <= columns; column++) Console.Write(" ");
        Console.Write("|");

        Console.Write("\n");
      }
    }

    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("=======");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma opção abaixo");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo Arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");
      Console.SetCursorPosition(3, 9);
      Console.WriteLine("0 - Sair");
      Console.SetCursorPosition(3, 10);

      Console.Write("Opção: ");
    }
  }
}