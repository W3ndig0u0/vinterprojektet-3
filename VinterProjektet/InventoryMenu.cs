using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class InventoryMenu
  {
    // !Statsen ska komma från Gameplay

    public void InventoryListShow(Character character)
    {
      if (character.GetInventoryLength() != 0)
      {
        Console.WriteLine("HEJSAN");
      }
      character.GetInventoryLength();

      string promt = "Your items: @You have " + character.GetInventoryLength() + " items.";
      promt = promt.Replace("@", System.Environment.NewLine);

      List<string> menuOptions = new List<string>();
      foreach (Item item in character.Items)
      {
        menuOptions.Add(item.Name);
      }

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
          Console.WriteLine($"Använd saker i listan");

          Console.ReadLine();
          break;

        case 1:
          Console.WriteLine("kolla saken i listan");
          Console.WriteLine("inventory har : " + character.GetInventoryLength() + " platser tagna.");
          Console.WriteLine($"vilken nummer i inventory Vill du kolla itemet på?");
          // character.GetItemInfo(int.Parse(Console.ReadLine()));
          Console.ReadLine();
          break;

        case 2:
          Console.WriteLine("inventory har : " + character.GetInventoryLength() + " platser tagna.");
          Console.WriteLine($"What do you want to throw away?");
          // character.RemoveFromInventory(int.Parse(Console.ReadLine()));
          Console.ReadLine();
          break;

        case 3:
          break;

        default:
          Console.WriteLine("Error");
          break;
      }
    }

  }
}