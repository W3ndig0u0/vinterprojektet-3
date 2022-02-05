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
      healing = rand.Next(100, 150);
      target.Hp += healing;
      Console.WriteLine("The " + target.Name + " uses a Potion!");
      Console.WriteLine("The " + target.Name + " heals himself for " + healing + " Points");
      Console.WriteLine();
    }

  }
}