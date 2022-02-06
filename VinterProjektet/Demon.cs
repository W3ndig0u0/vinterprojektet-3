using System;

namespace VinterProjektet
{
  public class Demon : Character
  {
    public Demon(int hp, string name, int baseStrength) : base(hp, name, baseStrength)
    {
      Hp = hp;
      Name = name;
      BaseStrength = baseStrength;
    }
    void flee(){
      
    }
  }
}