using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class InventoryMenu
  {
    Character character = new Character();
    Weapons weapon = new Weapons();

    public void InventoryItems()
    {
      string promt = "What do you want to do?@";
      promt = promt.Replace("@", System.Environment.NewLine);

      List<string> menuOptions = new List<string>() { "Use Something", "More Info about an Item", "Throw something", "Go Back to the Game" };
      MenuFunction inventoryItemsMenu = new MenuFunction(promt, menuOptions);

      // ?Få tillbaka vad SelectedIndex är
      int selectedIndex = inventoryItemsMenu.Run();
    }

    public void InventoryQuestion()
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
        // case 1:
        //   Console.WriteLine($"Lägg något i listan");
        //   character.Run();
        //   character.AddToInventory(weapon);
        //   new Inventory().Add(weapon);
        //   Console.WriteLine(character.GetInventoryLength());
        //   Console.ReadLine();
        //   break;

        case 1:
          Console.WriteLine($"Använd saker i listan");

          Console.ReadLine();
          break;

        case 2:
          Console.WriteLine("kolla saken i listan");
          Console.WriteLine("inventory har : " + character.GetInventoryLength() + " platser tagna.");
          Console.WriteLine($"vilken nummer i inventory Vill du kolla itemet på?");
          character.GetItemInfo(int.Parse(Console.ReadLine()));
          break;

        case 3:
          Console.WriteLine("inventory har : " + character.GetInventoryLength() + " platser tagna.");
          Console.WriteLine($"What do you want to throw away?");
          character.RemoveFromInventory(int.Parse(Console.ReadLine()));
          Console.ReadLine();
          break;

        case 4:
          new GamePlay().Game();
          break;

        default:
          Console.WriteLine("Error");
          break;
      }
    }
  }
}