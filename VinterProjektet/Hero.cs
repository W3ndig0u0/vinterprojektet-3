using System;

namespace VinterProjektet
{
  public class Hero : Character
  {
    public Hero(int maxHp, int hp, string name, int baseStrength) : base(maxHp, hp, name, baseStrength)
    {
      MaxHp = maxHp;
      Hp = hp;
      Name = name;
      BaseStrength = baseStrength;
    }

    protected int level;
    public int Level
    {
      get { return level; }
      set { level = value; }
    }

    // ?50/50 om man lyckas defenda
    public void Defend(Character target)
    {
      Random rand = new Random();
      int defendChance = rand.Next(0, 100);

      if (defendChance > 70)
      {
        Console.WriteLine("The " + this.Name + " Succsessfuly defended himself!");
        Console.WriteLine();
        target.Strength /= 3;
      }
      else
      {
        Console.WriteLine("The " + this.Name + " fricked up and took extra damage!");
        Console.WriteLine();
        target.Strength *= 2;
      }
    }

    void levelUp()
    {
      // !Levlar up för varje fiende du dödar 
    }

    void AntiDemonAttack()
    {
      // !Om fiende är en Demon så finns det en chans att du skadar dubbelt
      // !Måste recharga denna för att använda den
    }

    void Blessed()
    {
      // !Om fiende är en Demonking så finns det en chans att du överlever en dödlig attack
    }

  }
}