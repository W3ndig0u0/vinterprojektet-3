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

    protected int levelExp;
    public int LevelExp
    {
      get { return levelExp; }
      set { levelExp = value; }
    }

    protected int levelExpCap = 20;
    public int LevelExpCap
    {
      get { return levelExpCap; }
      set { levelExpCap = value; }
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

    public void levelUp()
    {
      level++;
      levelExp = 0;
      levelExpCap += 20;
      BaseStrength += 10;
      MaxHp += 5;
      Hp += 10;
      Console.WriteLine("You gained 1 Lv.");
      Console.WriteLine("Level: " + (level - 1) + " ==> " + level);
      Console.WriteLine("BaseStrength: " + (BaseStrength - 10) + " ==> " + BaseStrength);
      Console.WriteLine("MaxHp: " + (MaxHp - 5) + " ==> " + MaxHp);
      Console.WriteLine("Hp: " + (Hp - 5) + " ==> " + Hp);
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