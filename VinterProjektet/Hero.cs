using System;

namespace VinterProjektet
{
  public class Hero : Character
  {
    public Hero(int hp, string name, int baseStrength) : base(hp, name, baseStrength)
    {
      Hp = hp;
      Name = name;
      BaseStrength = baseStrength;
    }
  }
}