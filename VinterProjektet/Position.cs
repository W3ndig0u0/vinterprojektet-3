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
  }
}