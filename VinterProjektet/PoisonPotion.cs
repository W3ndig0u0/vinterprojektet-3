using System;

namespace VinterProjektet
{
  public class PoisonPotion : Item
  {
    public PoisonPotion(string name, int level) : base(name, level)
    {
      Name = "PoisonPotion";
      Level = 1;
    }

    public override void Use(Character target)
    {
      Random rand = new Random();
      int poison;
      poison = rand.Next(100, 150);
      target.Hp -= poison;
      Console.WriteLine("You used a Poison Potion!");
      Console.WriteLine("The " + target.Name + " lost " + poison + " Health points");
      Console.WriteLine();
    }

    public override void GetInfo()
    {
      Console.WriteLine("The Item's Name is " + Name);
      Console.WriteLine("The Item's level is " + Level);
      Console.WriteLine("Poison Potion is used for hurting enemys");
    }

  }
}