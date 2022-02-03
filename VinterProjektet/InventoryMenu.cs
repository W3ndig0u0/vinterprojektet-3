using System;

namespace VinterProjektet
{
  public class InventoryMenu
  {
    Character character = new Character();
    Weapons weapon = new Weapons();

    public void StartMenuText()
    {
      Console.WriteLine("Välj vad du vill göra");
      Console.WriteLine();

      Console.WriteLine("1. Lägg saker i listan");
      Console.WriteLine("2. Ta bort saker i Listan");
      Console.WriteLine("3. Använd saker i listan");
      Console.WriteLine("4. Få Listans Count");
      Console.WriteLine("5. kolla listan");

      Console.WriteLine("6. Quit");
    }

    public void MenuSwitch(int MenuNr)
    {
      switch (MenuNr)
      {
        case 1:
          Console.WriteLine($"Lägg något i listan");
          character.Run();
          character.AddToInventory(weapon);
          weapon.Name = Console.ReadLine();
          new Inventory().Add(weapon);
          Console.WriteLine(character.GetInventoryLength());
          Console.ReadLine();
          break;

        case 2:
          Console.WriteLine($"Ta bort saker i Listan.");
          Console.WriteLine("inventory har : " + character.GetInventoryLength() + " platser tagna.");
          Console.WriteLine($"vilken nummer i inventory Vill du ta bort?");
          character.RemoveFromInventory(int.Parse(Console.ReadLine()));
          Console.ReadLine();
          break;

        case 3:
          Console.WriteLine($"Använd saker i listan");

          Console.ReadLine();
          break;

        case 4:
          Console.WriteLine("Få Listans Count");
          Console.WriteLine(character.GetInventoryLength());
          break;

        case 5:
          Console.WriteLine("kolla saken i listan");
          Console.WriteLine("inventory har : " + character.GetInventoryLength() + " platser tagna.");
          Console.WriteLine($"vilken nummer i inventory Vill du kolla itemet på?");
          character.GetItemInfo(int.Parse(Console.ReadLine()));
          break;

        case 6:
          Environment.Exit(0);
          break;

        default:
          Console.WriteLine("Error");
          break;
      }
    }
  }
}