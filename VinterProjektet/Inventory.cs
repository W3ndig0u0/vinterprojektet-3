using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class Inventory
  {

    //! Bör ha någon form av felkoll så att spelet inte krashar när man försöker använda eller hämta information om ett item som inte finns

    List<Item> inventoryList = new List<Item>();

    public void Add(Item item)
    {
      //? Lägger en instans av Item i listan.
      inventoryList.Add(item);
    }

    public void Remove(int n)
    {
      //? Tar bort föremålet i den exakta positionen i Listan.
      inventoryList.RemoveAt(n);
    }

    public string GetItemInfo(int n)
    {
      string ItemInfo = inventoryList[n].ToString();
      return ItemInfo;
    }

    public void UseItem(int n, Character c)
    {

    }

    public int GetLength()
    {
      int amountInventory = inventoryList.Count;
      return amountInventory;
    }

  }


}