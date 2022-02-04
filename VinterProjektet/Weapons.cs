using System;

namespace VinterProjektet
{
  public class Weapons : Item
  {
    public override void Use(Character target)
    {
      Name = "Sword";
      Console.WriteLine("The sword says: wee wee");
      Console.WriteLine("And your strength is increased by 10 points");
      target.Strength += 10;
    }

  }
}