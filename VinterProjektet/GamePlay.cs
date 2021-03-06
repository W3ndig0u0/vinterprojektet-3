using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class GamePlay
  {
    Hero hero = new Hero(50, 50, "Player", 10);

    Demon enemy = new Demon(50, 50, "Lesser Demon", 10);
    DemonLord demonKing = new DemonLord(500, 500, "DemonKing", 100);

    HealPotions healPotions = new HealPotions("Healpotions", 1);
    PoisonPotion poisonPotion = new PoisonPotion("PoisonPotion", 1);
    Weapons sword = new Weapons("Weapons", 1);


    void DisplayChoices(Character enemy)
    {
      string promt = "You are facing " + enemy.Name;
      // !Skriv ned ifall de har en item + level

      promt = promt.Replace("@", System.Environment.NewLine);

      List<string> menuOptions = new List<string>() { "Attack", "Defend", "Check Inventory", "Quit Game" };
      MenuFunction menu = new MenuFunction(promt, menuOptions);

      // ?Få tillbaka vad SelectedIndex är
      int selectedIndex = menu.Run(1, hero, enemy);
      menu.Run(1, hero, enemy);

      switch (selectedIndex)
      {
        case 0:
          hero.AntiDemonAttack(enemy);
          hero.Attack(enemy);
          break;

        case 1:
          hero.Defend(enemy);
          break;

        case 2:
          new InventoryMenu().InventoryListShow(hero, enemy);
          break;

        case 3:
          new StartMenu().QuitGame();
          break;

        default:
          Console.WriteLine("Sorry that choice was invalid");
          break;
      }
    }

    public void Game(Character enemy)
    {
      // ?Om någon dör slutar while loopen
      while (hero.Hp > 0 && enemy.Hp > 0)
      {
        // !Base Strength, Vapen ökar den
        hero.GetAttack(hero.BaseStrength);
        enemy.GetAttack(enemy.BaseStrength);
        DisplayChoices(enemy);

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

    // ?Ger en random Item till spelaren när en demon besegras
    void Reward()
    {
      List<Item> Items = new List<Item>() { healPotions, poisonPotion, sword };
      Random random = new Random();
      int i = random.Next(0, 3);
      Console.WriteLine(Items[i].Name + " Level: " + Items[i].Level + " got added to your inventory.");
      hero.AddToInventory(Items[i]);
      Console.WriteLine("you have now " + hero.GetInventoryLength() + " things on your inventory.");
      Console.WriteLine("Press Enter to Continue");
      Console.ReadLine();
      Console.Clear();
    }

    // ?Detta returnenar en ranom fiende
    Character RandomEnemy()
    {
      List<Character> enemyTypes = new List<Character>() { enemy, demonKing };

      Random random = new Random();
      int i = random.Next(0, 10);
      if (i <= 1)
      {
        Console.WriteLine("A " + enemyTypes[1].Name + " appeard in front of you.");
        enemyTypes[1].Hp = enemyTypes[1].MaxHp;
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        return enemyTypes[1];
      }
      else
      {
        Console.WriteLine("Another " + enemyTypes[0].Name + " appeard in front of you.");
        enemyTypes[0].Hp = enemyTypes[0].MaxHp;
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        return enemyTypes[0];
      }
    }

    // ?Ökar spelarens lv
    void expPlayer(Hero player)
    {
      player.LevelExp += 10;
      Console.WriteLine("The player's lv has increased by 10 points. (" + player.LevelExp + "/" + player.LevelExpCap + ")");

      if (player.LevelExp >= player.LevelExpCap)
      {
        player.LevelUp();
      }

      Console.WriteLine("Press Enter to Continue");
      Console.ReadLine();
      Console.Clear();
    }

    // ?Vad som händer när någon dör
    void CheckDeath()
    {
      if (hero.Hp <= 0)
      {
        Console.WriteLine("You died, bruh.");
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        new StartMenu().Start();
      }
      else
      {
        Console.Clear();
        Console.WriteLine("You are Victorious!");
        Reward();
        expPlayer(hero);
        Game(RandomEnemy());
        Console.Clear();
      }
    }

  }
}