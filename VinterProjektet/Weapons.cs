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
      Console.WriteLine("BaseStrength: " + (target.BaseStrength - 10) + " ==> " + target.BaseStrength);
    }

    public override void GetInfo()
    {
      Console.WriteLine("The Item's Name is " + Name);
      Console.WriteLine("The Item's level is " + Level);
      Console.WriteLine("The sword says: wee wee");
      Console.WriteLine("And the sword is used for increasing your strength by 10 points");
    }

  }
}