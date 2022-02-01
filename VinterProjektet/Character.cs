using System;

namespace VinterProjektet
{
  public class Character
  {
    protected string name;

    protected int hp;
    protected int mp;
    protected int strength;

    protected int y;
    protected int x;


    protected Inventory inventory;

    public void Run()
    {
      //? instance program class
      inventory = new Inventory();
    }

    // !Du behöver se till så att alla characters som skapas får en egen inventory.

    // !AddToInventory ska lägga in items i karaktärens inventory-instans.På samma sätt behöver RemoveFromInventory, UseItem och GetItemInfo anropa motsvarande metoder i inventory-instansen.

    // !Move ska lägga till/ta bort från karaktärens x- och y-värden, medan SetPosition anger exakt position som karaktären ska få.

    // !Båda versionerna av UseItem anropar inventory-instansens UseItem.metod.I versionen utan Character-parameter så är det “this”, alltså karaktären själv, som är target.


    public void AddToInventory(Item item)
    {
      inventor
    }

    public void RemoveFromInventory(Item item)
    {

    }

    public void UseItemOn(int n, Character target)
    {

    }

    public void UseItem(int n)
    {

    }

    public int GetInventoryLength()
    {

    }

    public void Move(int xMove, int yMove)
    {
    }

    public void SetPosition(int xPos, int yPos)
    {
    }

    public int GetX()
    {
      return
    }

    public int GetY()
    {
      return
    }

    public int GetHp()
    {
      return
    }


    public int ModifyHp(int amount)
    {
      return
    }

    public void Attack(Character target)
    {

    }

  }

}