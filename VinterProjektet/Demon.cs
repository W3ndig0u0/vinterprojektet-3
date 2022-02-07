using System;

namespace VinterProjektet
{
  public class Demon : Character
  {
    public Demon(int maxHp, int hp, string name, int baseStrength) : base(maxHp, hp, name, baseStrength)
    {
      MaxHp = maxHp;
      Hp = hp;
      Name = name;
      BaseStrength = baseStrength;
    }
  }
}