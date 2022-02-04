using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class Game
  {
    public void Start()
    {
      string promt = "Welcome to the Inventory. What to you want to do?";
      List<string> menuOptions = new List<string>() { "Start", "About", "Quit" };

      Menu startMenu = new Menu(promt, menuOptions);
      startMenu.Run();

      Console.ReadKey(true);
    }
  }
}