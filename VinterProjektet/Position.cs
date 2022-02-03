using System;

namespace VinterProjektet
{
  public class Position
  {
    // !Rita sakerna
    public void PrintOnPosition(int x, int y, Character c, ConsoleColor color)
    {
      Console.SetCursorPosition(x, y);
      Console.ForegroundColor = color;
      Console.Write(c.CharacterSymbol);
    }

    // !Rita texten
    public static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color)
    {
      Console.SetCursorPosition(x, y);
      Console.ForegroundColor = color;
      Console.Write(str);
    }
  }
}