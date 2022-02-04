using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class Game
  {
    public void Start()
    {
      // Console.WriteLine("w");
      //?Vill inte se vad spelaren skriver, bara om en knapp trycks
      //? så att programmet kan se om det är en av menyn kontroll knapparna.

      //? ConsoelkeyInfo returneras när man gör en Readkey, detta låter oss se vad för knapp man track på
      // ConsoleKeyInfo keyPressed = Console.ReadKey();

      // if (keyPressed.Key == ConsoleKey.Enter)
      // {
      //   Console.WriteLine("ENTER");
      // }
      // else if (keyPressed.Key == ConsoleKey.UpArrow)
      // {
      //   Console.WriteLine("UP Arrow");
      // }
      // else if (keyPressed.Key == ConsoleKey.DownArrow)
      // {
      //   Console.WriteLine("DownArrow");
      // }
      // else if (keyPressed.Key == ConsoleKey.LeftArrow)
      // {
      //   Console.WriteLine("LeftArrow");
      // }
      // else if (keyPressed.Key == ConsoleKey.RightArrow)
      // {
      //   Console.WriteLine("RightArrow");
      // }
      // else
      // {
      //   Console.WriteLine("Error");
      // }
      string promt = "Welcome to the Inventory. What to you want to do?";
      List<string> menuOptions = new List<string>() { "Start", "About", "Quit" };

      Menu startMenu = new Menu(promt, menuOptions);
      startMenu.DisplayOptions();

      Console.ReadKey(true);
    }
  }
}