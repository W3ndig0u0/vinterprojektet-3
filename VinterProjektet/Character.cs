using System;

namespace VinterProjektet
{
  public class Character
  {
    protected string name;

    //? Istället för  en method för get används propertys.

    protected int x;
    public int X   //? property
    {
      get { return x; }   //? GetX() methoden
      set { x = value; }
    }

    protected int y;
    public int Y //? property
    {
      get { return y; } //?GetY()
      set { y = value; }
    }

    protected int hp;
    public int Hp //? property
    {
      get { return hp; } //?GetHp()
      set { hp = value; } //?ModifyHp()
    }

    protected int mp;
    protected int Mp
    {
      get { return mp; }
      set { mp = value; }
    }

    protected int strength;
    public int Strength
    {
      get { return strength; }
      set { strength = value; }
    }


    protected Inventory inventory;

    public void Run()
    {
      //? instance program class
      inventory = new Inventory();
    }


    // !AddToInventory ska lägga in items i karaktärens inventory-instans. 
    public void AddToInventory(Item item)
    {
      inventory.Add(item);
    }

    // !På samma sätt behöver RemoveFromInventory, UseItem och GetItemInfo anropa motsvarande metoder i inventory-instansen.
    public void RemoveFromInventory(int n)
    {
      inventory.Remove(n);
    }

    public void UseItem(int n, Character target)
    {
      inventory.UseItem(n, target);
    }

    public void UseItem(int n)
    {
      inventory.UseItem(n, this);
    }

    public string GetItemInfo(int n)
    {
      return inventory.GetItemInfo(n);
    }

    public int GetInventoryLength()
    {
      return inventory.GetLength();
    }

    public void Attack(Character target)
    {
      target.hp -= strength;
    }
  }

}