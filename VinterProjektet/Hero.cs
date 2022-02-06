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

    void AntiDemonAttack()
    {
      // !Om fiende är en Demonking så finns det en chans att du skadar dubbelt 
    }

    void Blessed()
    {
      // !Om fiende är en Demonking så finns det en chans att du överlever en dödlig attack
    }

  }
}