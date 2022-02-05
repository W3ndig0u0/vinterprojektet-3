using System;

namespace VinterProjektet
{
  public class Weapons : Item
  {

    public Weapons(string name, int level) : base(name, level)
    {
      Name = "Sword";
      Level = 1;
    }

    public override void Use(Character target)
    {
      Console.WriteLine("The sword says: wee wee");
      Console.WriteLine("And your strength is increased by 10 points");
      target.BaseStrength += 10;
    }

  }
}