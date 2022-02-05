using System;

namespace VinterProjektet
{
  // ?Abstract klass är en klass som inte kan instansieras och skapa objekt
  // ? Den är inte en interface för att den har metoden GetInfo() som har kod i sig
  public abstract class Item
  {

    // !Use-metoden tar emot en instans av character, vilket gör att den kan användas för att t.ex.öka en karaktärs hp, flytta den, etc…

    // !Use-metoden bör vara tom, eftersom denna klass aldrig instansieras i spelet; det finns inga generella “Items”, alla har sina egna namn + effekt.

    // !Item-klassen och dess Use-metod kan med fördel vara abstrakta.

    // ? en Abstract metod kan inte ha kod i sig, koden kommer från klassen som Item ärver från
    public abstract void Use(Character target);

    protected string name;
    public string Name   //? property
    {
      get { return name; }
      set { name = value; }
    }

    protected int level;
    public int Level
    {
      get { return level; }
      set { level = value; }
    }

    public Item(string name, int level)
    {
      Name = name;
      Level = level;
    }

    public void GetInfo()
    {
      Console.WriteLine("The Item's Name is " + Name);
      Console.WriteLine("The Item's level is " + Level);
    }

  }
}