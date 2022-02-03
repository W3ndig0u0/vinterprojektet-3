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
    protected int strength;

    protected Inventory inventory;

    public void Run()
    {
      //? instance program class
      inventory = new Inventory();
      Console.WriteLine("Hello");
      Console.WriteLine(GetInventoryLength());
    }


    // !Du behöver se till så att alla characters som skapas får en egen inventory.

    // !Båda versionerna av UseItem anropar inventory-instansens UseItem.metod.I versionen utan Character-parameter så är det “this”, alltså karaktären själv, som är target.

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

    }

    public void UseItem(int n)
    {

    }

    public string UseItemInfo(int n)
    {
      return inventory.GetItemInfo(n);
    }

    public int GetInventoryLength()
    {
      return inventory.GetLength();
    }

    // !Move ska lägga till/ta bort från karaktärens x- och y-värden
    public void Move(int xMove, int yMove)
    {
    }

    // ! SetPosition anger exakt position som karaktären ska få.
    public void SetPosition(int xPos, int yPos)
    {
    }


    public void Attack(Character target)
    {

    }


    // public int GetX()
    // {
    //   return x;
    // }

    // public int GetY()
    // {
    //   return y;
    // }

    // public int GetHp()
    // {
    //   return hp;
    // }


    // public int ModifyHp(int amount)
    // {
    //   return
    // }
  }

}