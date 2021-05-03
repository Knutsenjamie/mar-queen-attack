using System;

namespace ChessBoard
{
  public class Opponent
  {
    
    public int X { get; set; }
    public int Y { get; set; }
    public Opponent(int x, int y) {
      X = x;
      Y = y;
    }
  }
}