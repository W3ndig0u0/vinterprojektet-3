using System;

namespace VinterProjektet
{
  public class DemonKing : Character
  {

    public DemonKing(int hp, string name, int baseStrength) : base(hp, name, baseStrength)
    {
      Hp = hp;
      Name = name;
      BaseStrength = baseStrength;
    }
  }
}