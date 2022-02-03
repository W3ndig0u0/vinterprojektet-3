using System;

namespace VinterProjektet
{
  public class Weapons : Item
  {
    public override void Use(Character target)
    {
      Console.WriteLine("The sword says: wee wee");
    }

  }
}