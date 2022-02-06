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

    // !Ha en random nummer och bereonde på den samt fiende, välj en unik attack
    public override void enemyAttack()
    {

    }

    void flee()
    {

      // !Springer från fienden
    }

  }
}