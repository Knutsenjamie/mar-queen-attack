using System;

namespace ChessBoard
{
  public class Program
  {
    public static int askForPosition()
    {
      int requestedPosition = int.Parse(Console.ReadLine());
      bool outOfBounds = requestedPosition > 8 || requestedPosition < 1;
      if (outOfBounds)
      {
        Console.WriteLine("Please enter in a valid position (1-8)");
        requestedPosition = askForPosition();
      }
      return requestedPosition;
    }
    public static void Main()
    {
      Console.WriteLine("Welcome to a game of chess!");
      ChessPiece opponent = new(1, 1);
      Console.WriteLine($"Your opponent is sitting at ({opponent.X}, {opponent.Y})");
      Console.WriteLine("Where would you like your queen on the X? 1-8");
      int queenX = askForPosition();
      Console.WriteLine("Where would you like your queen on the Y? 1-8");
      int queenY = askForPosition();
      ChessPiece queen = new(queenX, queenY);
      Console.WriteLine($"({queen.X}, {queen.Y})");

    }
  }
}