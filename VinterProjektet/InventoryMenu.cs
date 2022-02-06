using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class InventoryMenu
  {
    // ?Karaktär instansen kommer från Gameplay
    public void InventoryListShow(Character character)
    {
      character.GetInventoryLength();

      string promt = "Your items: @You have " + character.GetInventoryLength() + " items.";
      promt = promt.Replace("@", System.Environment.NewLine);

      // !Skriv ned alla items som man har i Inventory!!
      // !Skriv ned alla items som man har i Inventory!!
      // !Skriv ned alla items som man har i Inventory!!

      List<string> menuOptions = new List<string>();
      MenuFunction menu = new MenuFunction(promt, menuOptions);

      // ?Få tillbaka vad SelectedIndex är
      int selectedIndex = menu.Run();
      menu.Run();

      switch (selectedIndex)
      {
        case 0:
          InventoryQuestion(character, selectedIndex);
          break;

        case 1:
          InventoryQuestion(character, selectedIndex);
          break;

        case 2:
          InventoryQuestion(character, selectedIndex);
          break;

        case 3:
          InventoryQuestion(character, selectedIndex);
          break;

        default:
          Console.WriteLine("Error");
          break;
      }
    }

    // ?Parameterna innehåller vilken itemIndex spelaren valde
    public void InventoryQuestion(Character character, int itemListIndex)
    {
      string promt = "What do you want to do?@";
      promt = promt.Replace("@", System.Environment.NewLine);

      List<string> menuOptions = new List<string>() { "Use Something", "More Info about an Item", "Throw something", "Go Back to the Game" };
      MenuFunction menu = new MenuFunction(promt, menuOptions);

      // ?Få tillbaka vad SelectedIndex är
      int selectedIndex = menu.Run();
      menu.Run();


      switch (selectedIndex)
      {
        case 0:
          Console.WriteLine($"Using the Item");
          // !Detta use är bara för heal
          // !ha en if statement om itemet är en poisenpotion
          character.UseItem(itemListIndex, character);
          Console.ReadLine();
          break;

        case 1:
          Console.WriteLine("Getting More information about the selected item.");
          character.GetItemInfo(itemListIndex);
          Console.ReadLine();
          break;

        case 2:
          Console.WriteLine($"Throwing away the selected item.");
          character.RemoveFromInventory(itemListIndex);
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