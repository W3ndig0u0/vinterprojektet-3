using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class Character
  {
    //? Istället för  en method för get används propertys.
    protected int hp;
    public int Hp //? property
    {
      get { return hp; } //?GetHp()
      set { hp = value; } //?ModifyHp()
    }

    protected int maxHp;
    public int MaxHp
    {
      get { return maxHp; }
      set { maxHp = value; }
    }

    protected string name;
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    protected int strength;
    public int Strength
    {
      get { return strength; }
      set { strength = value; }
    }

    protected int baseStrength;
    public int BaseStrength
    {
      get { return baseStrength; }
      set { baseStrength = value; }
    }

    public Character(int maxHp, int hp, string name, int baseStrength)
    {
      MaxHp = maxHp;
      Hp = hp;
      Name = name;
      BaseStrength = baseStrength;
      Inventory();
    }

    protected Inventory inventory;

    public void Inventory()
    {
      //? ny inventory för varje karkatär
      inventory = new Inventory();
    }

    public void ShowInventory()
    {
      inventory.ShowInventory();
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

    public void GetItemInfo(int n)
    {
      inventory.GetItemInfo(n);
    }

    public int GetInventoryLength()
    {
      int amount = inventory.GetLength();
      return amount;
    }

    public string GetInventoryName(int itemListIndex)
    {
      return inventory.GetInventoryName(itemListIndex);
    }


    // ?Får en random attack
    public void GetAttack(int baseStrength)
    {
      Random rand = new Random();
      Strength = rand.Next(baseStrength / 2, baseStrength * 2);
      Strength += baseStrength;
    }

    // ?Hp bar
    public void HpBar()
    {
      Console.WriteLine(this.Name + "Health: ");
      Console.Write("[");

      // ?Den gröna och röda delen i hpbar
      // ?Beroende på karaktärens liv
      if (hp <= 19)
      {
        Console.BackgroundColor = ConsoleColor.Red;
        for (int i = 0; i < Hp; i++)
        {
          Console.Write(" ");
        }
      }

      else
      {
        Console.BackgroundColor = ConsoleColor.Green;
        for (int i = 0; i < Hp; i++)
        {
          Console.Write(" ");
        }
      }

      // ?resten av hpBaren blir svart
      Console.BackgroundColor = ConsoleColor.Black;
      for (int i = Hp; i < MaxHp; i++)
      {
        Console.Write(" ");
      }
      Console.ResetColor();

      Console.WriteLine("] (" + Hp + "/" + MaxHp + ")");
    }

    // !Ha en random nummer och bereonde på den samt fiende, välj en unik attack
    public virtual void enemyAi()
    {

    }

    // ?Attacking
    public virtual void Attack(Character target)
    {
      Random rand = new Random();
      int hitChance = rand.Next(0, 100);
      if (hitChance >= 20)
      {
        Console.WriteLine("The " + this.Name + " attacks!");
        target.Hp -= Strength;
        Console.WriteLine("The " + target.Name + "loses " + Strength + "hp");
        Console.WriteLine();
      }
      else
      {
        Console.WriteLine("The " + this.Name + " missed!");
        Console.WriteLine();
      }
    }

  }

}