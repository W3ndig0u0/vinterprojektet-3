using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class GamePlay
  {
    Hero hero = new Hero(50, 50, "Player", 10);
    Demon demonKing = new Demon(50, 50, "Lesser Demon", 10);
    DemonKing enemy = new DemonKing(1000, 1000, "DemonKing", 50);

    HealPotions healPotions = new HealPotions("Healpotions", 1);
    PoisonPotion poisonPotion = new PoisonPotion("PoisonPotion", 1);
    Weapons sword = new Weapons("Weapons", 1);


    void DisplayChoices()
    {
      // List<Character> character = new List<Character>() { hero, enemy, demonKing };

      List<Item> Items = new List<Item>() { healPotions, poisonPotion, sword };
      string promt = "You are facing " + enemy.Name;
      // !Skriv ned ifall de har en item + level

      promt = promt.Replace("@", System.Environment.NewLine);

      List<string> menuOptions = new List<string>() { "Attack", "Defend", "Check Inventory", "Get Item", "Quit Game" };
      MenuFunction menu = new MenuFunction(promt, menuOptions);

      // ?Få tillbaka vad SelectedIndex är
      int selectedIndex = menu.Run(1, hero, enemy);
      menu.Run(1, hero, enemy);

      switch (selectedIndex)
      {
        case 0:
          hero.Attack(enemy);
          break;

        case 1:
          hero.Defend(enemy);
          break;

        case 2:
          new InventoryMenu().InventoryListShow(hero, enemy);
          break;

        case 3:
          // !Lägg detta när man vinner över en monster
          // !Lägg random monster varje gång
          // !Lägg random item som man får
          // !Gör flera sub karaktäerer
          Console.WriteLine(Items[0].Name + " Level: " + Items[0].Level + " got added to your inventory.");
          hero.AddToInventory(Items[0]);
          Console.WriteLine("you have now " + hero.GetInventoryLength() + " things on your inventory.");
          Console.WriteLine("Press Enter to Continue");
          Console.ReadLine();
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
      // ?Om någon dör slutar while loopen
      while (hero.Hp > 0 && enemy.Hp > 0)
      {
        // !Base Strength, Vapen ökar den
        hero.GetAttack(hero.BaseStrength);
        enemy.GetAttack(enemy.BaseStrength);
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
        Console.WriteLine("Press any key to Continue");
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