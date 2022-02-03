using System;

namespace VinterProjektet
{
  public class Character
  {
    protected string name;

    //? Istället för  en method för get används propertys.
    // ?Detta är spelarens karaktär
    char characterSymbol;
    public char CharacterSymbol   //? property
    {
      get { return characterSymbol; }   //? GetX() methoden
      set { characterSymbol = value; }
    }


    ConsoleColor color;
    
    public ConsoleColor Color   //? property
    {
      get { return color; }   //? GetX() methoden
      set { color = value; }
    }

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
      inventory.UseItem(n, target);
    }

    // !Hur ska jag använda UseItem med bara n?
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

    // !Move ska lägga till/ta bort från karaktärens x- och y-värden
    public void Move(int xMove, int yMove)
    {

    }

    // ! SetPosition anger exakt position som karaktären ska få.
    public void SetPosition(int xPos, int yPos)
    {
      new Position().PrintOnPosition(xPos, yPos, this, ConsoleColor.Cyan);
    }


    public void Attack(Character target)
    {
      target.hp -= strength;
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