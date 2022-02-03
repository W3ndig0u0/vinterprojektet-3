using System;

namespace VinterProjektet
{
  public class InventoryMenu
  {
    public void MenuSwitch(int MenuNr)
    {
      switch (MenuNr)
      {
        case 1:
          Console.WriteLine($"You have chosen Attackers.");

          Console.ReadLine();
          break;

        case 2:
          Console.WriteLine($"You have chosen Defenders.");

          Console.ReadLine();
          break;

        case 3:
          Console.WriteLine($"You have chosen Speedsters.");

          Console.ReadLine();
          break;

        case 4:
          break;

        case 5:
          break;

        case 6:
          Environment.Exit(0);
          break;

        default:
          Console.WriteLine("Error, try Again");
          break;
      }
    }

  }
}