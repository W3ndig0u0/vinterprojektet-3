using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class MenuFunction
  {
    // !Menyn ska hålla koll på indexen i Listan
    int SelectedIndex;
    List<string> MenuOptions = new List<string>();
    string Promt;


    public MenuFunction(string promt, List<string> menuOptions)
    {
      Promt = promt;
      MenuOptions = menuOptions;
      SelectedIndex = 0;
    }

    // ?Detta rendrar menyn
    void DisplayOptions(int n, Character hero, Character enemy)
    {
      Console.WriteLine(Promt);

      switch (n)
      {
        case 0:
          // ?Om inte någon metod ska köras.
          menuOptions();
          break;

        case 1:
          hero.HpBar();
          enemy.HpBar();
          menuOptions();
          break;
        case 2:
          hero.ShowInventory();
          menuOptions();
          break;

        default:
          Console.WriteLine("Error, unknown option");
          break;
      }
    }

    void menuOptions()
    {
      // !Skriver ut allt i listan
      for (int i = 0; i < MenuOptions.Count; i++)
      {

        string currentOptions = MenuOptions[i];
        string prefix;

        //? SelectedIndex är den menuOptions som använderen valde.
        if (i == SelectedIndex)
        {
          prefix = "*";
          Console.ForegroundColor = ConsoleColor.Black;
          Console.BackgroundColor = ConsoleColor.White;
        }
        else
        {
          prefix = " ";
          Console.ForegroundColor = ConsoleColor.White;
          Console.BackgroundColor = ConsoleColor.Black;
        }
        Console.WriteLine(prefix + "<< " + currentOptions + " >>");
      }
      Console.ResetColor();
    }

    // !Blev trött, fixar detta senare ifall jag blir smartare
    // ?Koden som körs, låter spelaren ändra selectedIndex
    public int Run(int n, Character hero, Character enemy)
    {
      ConsoleKey keyPressed;
      do
      {
        Console.Clear();
        DisplayOptions(n, hero, enemy);

        //? ConsoelkeyInfo returneras när man gör en Readkey, detta låter oss se vad för knapp man track på
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        keyPressed = keyInfo.Key;

        //? Uppdaterar SelectedIndex baserat på vad användaren trycker.

        if (keyPressed == ConsoleKey.UpArrow)
        {
          SelectedIndex--;
          if (SelectedIndex == -1)
          {
            SelectedIndex = MenuOptions.Count - 1;
          }
        }
        else if (keyPressed == ConsoleKey.DownArrow)
        {
          SelectedIndex++;
          if (SelectedIndex == MenuOptions.Count)
          {
            SelectedIndex = 0;
          }
        }

      } while (keyPressed != ConsoleKey.Enter);

      return SelectedIndex;
    }

  }
}