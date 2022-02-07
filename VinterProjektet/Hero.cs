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

    protected int spAttackRecharge;
    public int SpAttackRecharge
    {
      get { return spAttackRecharge; }
      set { spAttackRecharge = value; }
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

    // ?Vad som händer när spelaren levlas upp
    public void LevelUp()
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

    // ?Visar spelarens lv och baseStrength
    public void CheckStatsHero(Hero c)
    {
      Console.WriteLine(c.Name + "is Level: " + c.Level);
      Console.WriteLine(c.Name + " BaseStrength: " + BaseStrength);
    }


    public void AntiDemonAttack(Character target)
    {
      // !Om fiende är en DemonLord ökar din strength med 3
      if (target is DemonLord)
      {
        Console.Clear();
        Console.WriteLine("Your opponent is a DemonLord, and such you felt a special power within you.");
        Console.WriteLine();
        Console.WriteLine("BaseStrength: " + (BaseStrength) + " ==> " + BaseStrength * 3);
        BaseStrength *= 3;
      }
    }

  }
}