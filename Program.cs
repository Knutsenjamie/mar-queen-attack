using System;

namespace ChessBoard
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to a game of chess!");
      Opponent opponent = new Opponent(1, 1);
    }
  }
}