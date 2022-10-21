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
  }
}