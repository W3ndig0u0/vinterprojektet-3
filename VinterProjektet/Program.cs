using System;

namespace VinterProjektet
{
  class Program
  {
    static void Main(string[] args)
    {
      //? Koden kör Character Run methoden
      GamePlay game = new GamePlay();
      game.Run();
      Console.ReadLine();
    }
  }
}
