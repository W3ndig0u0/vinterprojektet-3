using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class InventoryMenu
  {
    // ?Karaktär instansen kommer från Gameplay
    public void InventoryListShow(Character player, Character enemy)
    {
      player.GetInventoryLength();

      string promt = "Your items: @You have " + player.GetInventoryLength() + " items.";
      promt = promt.Replace("@", System.Environment.NewLine);

      List<string> menuOptions = new List<string>();
      MenuFunction menu = new MenuFunction(promt, menuOptions);

      // ?Få tillbaka vad SelectedIndex är
      // !Inventory items skrivs ned genom menu run, fixar detta senare :)
      int selectedIndex = menu.Run(2, player, enemy);
      menu.Run(2, player, enemy);

      if (player.GetInventoryLength() == 0)
      {
        Console.WriteLine($"While you were looking in your empty inventory, the enemy tried to attack you");
        return;
      }

      // ?Parameterna innehåller vilken itemIndex spelaren valde
      switch (selectedIndex)
      {
        case 0:
          InventoryQuestion(player, selectedIndex, enemy);
          break;

        case 1:
          InventoryQuestion(player, selectedIndex, enemy);
          break;

        case 2:
          InventoryQuestion(player, selectedIndex, enemy);
          break;

        case 3:
          InventoryQuestion(player, selectedIndex, enemy);
          break;

        default:
          Console.WriteLine("Error");
          break;
      }
    }

    // ?Parameterna innehåller vilken itemIndex spelaren valde
    public void InventoryQuestion(Character player, int itemListIndex, Character enemy)
    {
      string promt = "What do you want to do with? " + player.GetInventoryName(itemListIndex) + "@";
      promt = promt.Replace("@", System.Environment.NewLine);

      List<string> menuOptions = new List<string>() { "Use the " + player.GetInventoryName(itemListIndex), "More Info about the " + player.GetInventoryName(itemListIndex), "Throw away the " + player.GetInventoryName(itemListIndex), "Go Back to the Game" };
      MenuFunction menu = new MenuFunction(promt, menuOptions);

      // ?Få tillbaka vad SelectedIndex är
      int selectedIndex = menu.Run(0, player, enemy);
      menu.Run(0, player, enemy);


      switch (selectedIndex)
      {
        case 0:
          Console.WriteLine($"Using the Item");
          // !Detta use är bara för heal
          // !ha en if statement om itemet är en poisenpotion
          player.UseItem(itemListIndex, player);
          Console.ReadLine();
          break;

        case 1:
          Console.Clear();
          Console.WriteLine("Getting More information about the selected item:");
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
          Console.Clear();
          Console.WriteLine($"Throwing away a " + player.GetInventoryName(itemListIndex));
          player.RemoveFromInventory(itemListIndex);

          Console.WriteLine($"Press any button to continue.");
          Console.ReadLine();
          Console.Clear();

          Console.WriteLine($"While you were looking in your inventory, the enemy tried to attack you");
          Console.WriteLine($"Press any button to continue.");
          Console.ReadLine();
          break;

        case 3:
          Console.WriteLine($"While you were looking in your inventory, the enemy tried to attack you");
          break;

        default:
          Console.WriteLine("Error");
          break;
      }
    }

  }
}