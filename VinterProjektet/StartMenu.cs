using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class StartMenu
  {
    // !fixar detta senare...
    Hero hero = new Hero(100, 100, "Player", 10);
    Demon enemy = new Demon(100, 100, "Lesser Demon", 10);

    public void Start()
    {
      Console.Title = "Inventory - Jing Xiang Xu TE19B";
      RunStartMenu();
    }

    void RunStartMenu()
    {

      string promt = "Welcome to the Inventory. What to you want to do? @Move around in the Menu by using the up and down arrows.@Continue by pressing Enter.@";
      promt = promt.Replace("@", System.Environment.NewLine);

      List<string> menuOptions = new List<string>() { "Start", "About", "Quit" };
      MenuFunction menu = new MenuFunction(promt, menuOptions);

      // ?Få tillbaka vad SelectedIndex är
      int selectedIndex = menu.Run(0, hero, enemy);
      menu.Run(0, hero, enemy);

      switch (selectedIndex)
      {
        case 0:
          StartGame();
          break;

        case 1:
          AboutGame();
          break;

        case 2:
          QuitGame();
          break;

        default:
          break;
      }
    }

    // !Alternativen för menyn
    public void QuitGame()
    {
      Console.Clear();
      Console.WriteLine("Press Any key to Exit");
      Console.ReadKey(true);
      Environment.Exit(0);
    }

    void AboutGame()
    {
      Console.Clear();
      Console.WriteLine("This game is about evrething you need to know.");
      Console.WriteLine("Made by Jingxiang Xu");
      Console.ReadKey(true);
      RunStartMenu();
    }

    void StartGame()
    {
      Console.Clear();
      GamePlay game = new GamePlay();
      game.Game(enemy);
    }

  }
}