using System;

namespace VinterProjektet
{
  public class HealPotions : Item
  {

    public HealPotions(string name, int level) : base(name, level)
    {
      Name = name;
      Level = level;
    }

    public override void Use(Character target)
    {
      Random rand = new Random();
      int healing;
      healing = rand.Next(20, 50);
      target.Hp += healing;
      Console.WriteLine("The " + target.Name + " uses a Potion!");
      Console.WriteLine("The " + target.Name + " heals himself for " + healing + " Points");
      Console.WriteLine("Hp: " + (target.Hp - healing) + " ==> " + target.Hp);
      Console.WriteLine();
    }

    public override void GetInfo()
    {
      Console.WriteLine("The Item's Name is " + Name);
      Console.WriteLine("The Item's level is " + Level);
      Console.WriteLine("Healing Potions is used for healing the player");
    }

  }
}