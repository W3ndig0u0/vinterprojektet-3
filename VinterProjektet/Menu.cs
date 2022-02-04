using System;
using System.Collections.Generic;

namespace VinterProjektet
{
  public class Menu
  {
    // !Menyn ska hålla koll på indexen i Listan
    int SelectedIndex;
    List<string> MenuOptions = new List<string>();
    string Promt;


    public Menu(string promt, List<string> menuOptions)
    {
      Promt = promt;
      MenuOptions = menuOptions;
      SelectedIndex = 0;
    }

    // ?Detta rendrar menyn
    public void DisplayOptions()
    {
      Console.WriteLine(Promt);
      // !Skriver ut allt i listan
      for (int i = 0; i < MenuOptions.Count; i++)
      {
        string currentOptions = MenuOptions[i];
        Console.WriteLine("<< " + currentOptions + " >>");
      }
    }

  }
}