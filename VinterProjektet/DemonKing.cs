using System;

namespace VinterProjektet
{
  public class DemonKing : Character
  {

    public DemonKing(int maxHp, int hp, string name, int baseStrength) : base(maxHp, hp, name, baseStrength)
    {
      MaxHp = maxHp;
      Hp = hp;
      Name = name;
      BaseStrength = baseStrength;
    }

    // !Ha en random nummer och bereonde på den samt fiende, välj en unik attack
    public override void enemyAi()
    {

    }

    // !Ha en random nummer och bereonde på den samt fiende, välj en unik attack
    // !För varje miss, blir demon ännu starkare men i demonmode blir han dubbelt så stark för varje miss
    // !Annars blir han bara ca 10% starkare
    public override void Attack(Character target)
    {

    }

    void demonMode()
    {
      //! När demonking är har lite liv, blir den extra stark
      // !För varje miss, blir demon ännu starkare
    }

    void DeadlyAttack()
    {
      // !Liten chans att en attack dödar spelaren
    }

    void HealAttack()
    {
      // !Healar lika mycket som demonking skadar spelaren
    }

    void gameWon()
    {
      // !Speciell slut när man dödar DemonKing
    }



  }
}