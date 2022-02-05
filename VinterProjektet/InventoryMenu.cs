using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class InventoryMenu
  {
    // !Statsen ska komma från Gameplay
    Character character = new Character(1500, "player", 10);

    public void InventoryListShow()
    {
      string promt = "What item do you want to do more with?@";
      promt = promt.Replace("@", System.Environment.NewLine);

      // List<string> menuOptions = 
character.ShowInventory()

      MenuFunction menu = new MenuFunction(promt, menuOptions);

      // ?Få tillbaka vad SelectedIndex är
      int selectedIndex = menu.Run();
      menu.Run();

      switch (selectedIndex)
      {
        case 0:
          break;

        case 1:
          break;

        case 2:
          break;

        case 3:
          break;

        default:
          Console.WriteLine("Error");
          break;
      }
    }

    public void InventoryQuestion()
    {
      string promt = "What do you want to do?@?";
      promt = promt.Replace("@", System.Environment.NewLine);
      // promt = promt.Replace("?", character.ShowInventory());

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