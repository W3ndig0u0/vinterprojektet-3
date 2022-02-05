using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class Inventory
  {

    //! Bör ha någon form av felkoll så att spelet inte krashar när man försöker använda eller hämta information om ett item som inte finns
    string inventoryItem;
    public string InventoryItem
    {
      get { return inventoryItem; }
      set { inventoryItem = value; }
    }

    List<Item> inventoryList = new List<Item>();

    // ?returnerar baserat på listan
    public string ShowInventory()
    {
      if (inventoryList == null)
      {
        return "You do not have any items";
      }
      else
      {
        foreach (Item item in inventoryList)
        {
          InventoryItem += item.Name + System.Environment.NewLine;
        }
      }

      return InventoryItem;
    }

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
      //? Kollar infomationen i positionen n på Listan
      string ItemInfo = inventoryList[n].ToString();
      // Console.WriteLine(inventoryList[n].Name);
      return ItemInfo;
    }

    public void UseItem(int n, Character target)
    {
      // Weapons.Use(target);
    }

    public int GetLength()
    {
      return inventoryList.Count;
    }

  }


}