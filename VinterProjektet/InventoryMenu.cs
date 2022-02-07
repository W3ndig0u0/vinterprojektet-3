using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class InventoryMenu
  {
    // ?Karaktär instansen kommer från Gameplay
    public void InventoryListShow(Hero player, Character enemy)
    {
      player.GetInventoryLength();

      string promt = "Your items: @You have " + player.GetInventoryLength() + " items.";
      promt = promt.Replace("@", System.Environment.NewLine);

      List<string> menuOptions = new List<string>();
      MenuFunction menu = new MenuFunction(promt, menuOptions);

      player.ShowInventory();
      if (player.GetInventoryLength() <= 0)
      {
        Console.WriteLine($"While you were looking in your inventory, the enemy tried to attack you");
        Console.WriteLine($"Press any button to continue.");
        Console.ReadLine();
        return;
      }
      Console.WriteLine("Choose the number of Item");

      // !Fixa så att använderen har den andra menyn...
      string selectedIndexString = Console.ReadLine();
      int selectedIndex;

      while (!int.TryParse(selectedIndexString, out selectedIndex))       // Koden gör att den inte krashar om anvädaren inte följer instruktionerna.
      {
        Console.WriteLine();
        Console.WriteLine("Error, try again");

        selectedIndexString = Console.ReadLine();
      }

      // ?Parameterna innehåller vilken itemIndex spelaren valde
      InventoryQuestion(player, selectedIndex, enemy);

      if (player.GetInventoryLength() == 0)
      {
        Console.WriteLine($"While you were looking in your empty inventory, the enemy tried to attack you");
        return;
      }

    }

    // ?Parameterna innehåller vilken itemIndex spelaren valde
    public void InventoryQuestion(Hero player, int itemListIndex, Character enemy)
    {
      string promt = "What do you want to do with? " + player.GetInventoryName(itemListIndex) + "@";
      promt = promt.Replace("@", System.Environment.NewLine);

      List<string> menuOptions = new List<string>() { "Use the " + player.GetInventoryName(itemListIndex), "More Info about the " + player.GetInventoryName(itemListIndex), "Go Back to the Game" };
      MenuFunction menu = new MenuFunction(promt, menuOptions);

      // ?Få tillbaka vad SelectedIndex är
      int selectedIndex = menu.Run(0, player, enemy);
      menu.Run(0, player, enemy);


      switch (selectedIndex)
      {
        case 0:
          Console.WriteLine($"Using the " + player.GetInventoryName(itemListIndex));
          // !Fråga användaren vem som ska använda itemet.
          // Console.WriteLine("Who do you want to use it on?");
          player.UseItem(itemListIndex, player);
          player.RemoveFromInventory(itemListIndex);

          Console.WriteLine($"Press any button to continue.");
          Console.ReadLine();
          Console.Clear();
          Console.WriteLine($"While you were looking in your inventory, the enemy tried to attack you");
          Console.WriteLine($"Press any button to continue.");
          Console.ReadLine();
          break;

        case 1:
          Console.Clear();
          Console.WriteLine("Getting More information about " + player.GetInventoryName(itemListIndex) + ":");
          Console.WriteLine();
          player.GetItemInfo(itemListIndex);
          Console.WriteLine($"Press any button to continue.");
          Console.ReadLine();
          Console.Clear();

          Console.WriteLine($"While you were looking in your inventory, the enemy tried to attack you");
          Console.WriteLine($"Press any button to continue.");
          Console.ReadLine();
          break;

        case 2:
          Console.WriteLine($"While you were looking in your inventory, the enemy tried to attack you");
          break;

        default:
          Console.WriteLine("Error");
          break;
      }
    }

  }
}