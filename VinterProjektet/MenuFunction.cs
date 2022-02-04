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
    void DisplayOptions()
    {
      Console.WriteLine(Promt);
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


    // ?Koden som körs, låter spelaren ändra selectedIndex
    public int Run()
    {
      ConsoleKey keyPressed;
      do
      {

        Console.Clear();
        DisplayOptions();

        //? ConsoelkeyInfo returneras när man gör en Readkey, detta låter oss se vad för knapp man track på
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        keyPressed = keyInfo.Key;

        //? Uppdaterar SelectedIndex baserat på vad användaren trycker.

        //?Vill inte se vad spelaren skriver, bara om en knapp trycks
        //? så att programmet kan se om det är en av menyn kontroll knapparna.
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