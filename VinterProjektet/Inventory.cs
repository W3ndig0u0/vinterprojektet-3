using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class Inventory
  {

    //! Bör ha någon form av felkoll så att spelet inte krashar när man försöker använda eller hämta information om ett item som inte finns

    List<Item> inventoryList = new List<Item>();

    void Add(Item item)
    {
      //? Lägger en instans av Item i listan.
      inventoryList.Add(item);
    }

    void Remove(int n)
    {
      //? Tar bort föremålet i den exakta positionen i Listan.
      inventoryList.RemoveAt(n);
    }

    string GetItemInfo(int n)
    {
      string ItemInfo = inventoryList[n].ToString();
      return ItemInfo;
    }

    void UseItem(int n, Character c)
    {

    }

    int GetLength()
    {
      int amountInventory = inventoryList.Count;
      return amountInventory;
    }

  }


}