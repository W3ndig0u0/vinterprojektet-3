using System;

namespace VinterProjektet
{
  public class Item
  {

    // !Use-metoden tar emot en instans av character, vilket gör att den kan användas för att t.ex.öka en karaktärs hp, flytta den, etc…

    // !Use-metoden bör vara tom, eftersom denna klass aldrig instansieras i spelet; det finns inga generella “Items”, alla har sina egna namn + effekt.

    // !Item-klassen och dess Use-metod kan med fördel vara abstrakta.


    protected string name;

    public string GetInfo()
    {
      return;
    }

    void Use(Character target)
    {

    }
  }
}