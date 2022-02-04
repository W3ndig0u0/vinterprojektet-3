using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class GamePlay
  {
    InventoryMenu inventoryMenu = new InventoryMenu();
    Character hero = new Character();
    Character enemy = new Character();

    void DisplayChoices()
    {
      string promt = "You are facing " + enemy.Name + "!@@************************************************@You have " + hero.Hp + "hp. @The " + enemy.Name + " has " + enemy.Hp + "@************************************************@";
      promt = promt.Replace("@", System.Environment.NewLine);

      List<string> menuOptions = new List<string>() { "Attack", "Defend", "Check Inventory", "heal", "Quit Game" };
      MenuFunction startMenu = new MenuFunction(promt, menuOptions);

      // ?Få tillbaka vad SelectedIndex är
      int selectedIndex = startMenu.Run();
      startMenu.Run();

      switch (selectedIndex)
      {
        case 0:
          hero.Attack(enemy);
          break;

        case 1:
          hero.Defend(enemy);
          break;

        case 2:
          // ?Inventory
          Console.WriteLine("Inventory.");
          break;

        case 3:
          hero.heal(enemy);
          break;

        case 4:
          new StartMenu().QuitGame();
          break;

        default:
          Console.WriteLine("Sorry that choice was invalid");
          break;
      }
    }

    public void Game()
    {
      hero.Name = "Player";
      hero.Hp = 1500;

      enemy.Name = "enemy1";
      enemy.Hp = 2000;

      // ?Om någon dör slutar while loopen
      while (hero.Hp > 0 && enemy.Hp > 0)
      {
        // !Base Strength, Vapen ökar den
        hero.GetAttack(50);
        enemy.GetAttack(100);
        DisplayChoices();

        if (enemy.Hp > 0)
        {
          enemy.Attack(hero);
          Console.WriteLine("Press Enter to Continue");
          Console.ReadLine();
          Console.Clear();
        }
      }

      CheckDeath();
    }

    void CheckDeath()
    {
      if (hero.Hp > 0)
      {
        Console.WriteLine("You are Victorious!");
        // ?Gör så att man fortsätter
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        new StartMenu().Start();
      }
      else
      {
        Console.WriteLine("You died, bruh.");
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        new StartMenu().Start();
      }
    }

  }
}