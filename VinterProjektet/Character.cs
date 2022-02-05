using System;

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

    protected string name;
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    // !Används inte nu, kanske kostar postions mp? idk
    // protected int mp;
    // protected int Mp
    // {
    //   get { return mp; }
    //   set { mp = value; }
    // }

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

    public Character(int hp, string name, int baseStrength)
    {
      Hp = hp;
      Name = name;
      BaseStrength = baseStrength;
      Inventory();
    }


    protected Inventory inventory;

    public void Inventory()
    {
      //? instance program class
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

    public string GetItemInfo(int n)
    {
      return inventory.GetItemInfo(n);
    }

    public int GetInventoryLength()
    {
      int amount = inventory.GetLength();
      return amount;
    }


    // ?Får en random attack
    public void GetAttack(int baseStrength)
    {
      Random rand = new Random();
      Strength = rand.Next(baseStrength / 2, baseStrength * 2);
      Strength += baseStrength;
    }

    // ?50/50 om man lyckas defenda
    public void Defend(Character target)
    {
      Random rand = new Random();
      int defendChance = rand.Next(0, 100);

      if (defendChance > 50)
      {
        Console.WriteLine("The " + this.Name + " Succsessfuly defended himself!");
        Console.WriteLine();
        target.strength /= 3;
      }
      else
      {
        Console.WriteLine("The " + this.Name + " fricked up and took extra damage!");
        Console.WriteLine();
        target.strength *= 2;
      }
    }

    // ?Attacking
    public void Attack(Character target)
    {
      Random rand = new Random();
      int hitChance = rand.Next(0, 100);
      if (hitChance > 50)
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