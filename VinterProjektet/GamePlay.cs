using System;

namespace VinterProjektet
{
  public class GamePlay
  {
    InventoryMenu inventoryMenu = new InventoryMenu();

    public void Run()
    {
      int menuChoises = 0;
      string menuChoisesString = "";

      Console.WriteLine("Välkomen till Inventory");
      Console.WriteLine();
      inventoryMenu.StartMenuText();

      while (!int.TryParse(menuChoisesString, out menuChoises))
      // ?Koden gör att den inte krashar om anvädaren inte följer instruktionerna.
      {
        Console.WriteLine();
        Console.WriteLine("Det där är inte ett giltigt svar. Försök igen!");
        Console.Write("Ok, Jag väljer då: ");

        menuChoisesString = Console.ReadLine();
      }
      inventoryMenu.MenuSwitch(menuChoises);
    }
  }
}