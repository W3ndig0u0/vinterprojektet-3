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
        
      inventoryList.Add(item);
    }

    void Remove(int n)
    {
      inventoryList.RemoveAt(n);
    }

    string GetItemInfo(int n)
    {

    }

    void UseItem(int n, Character c)
    {

    }

    int GetLength()
    {

    }

  }


}