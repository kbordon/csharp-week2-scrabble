using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble.Models
{
  public class Game
  {
    static private char[][] _scoreSheet = new char[7][];
    private int _score;

    public Game()
    {
      _scoreSheet[0] = new char[] {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'}; //score 1
      _scoreSheet[1] = new char[] {'D', 'G'}; //score 2
      _scoreSheet[2] = new char[] {'B', 'C', 'M', 'P'}; //score 3
      _scoreSheet[3] = new char[] {'F', 'H', 'V', 'W', 'Y'}; //score 4
      _scoreSheet[4] = new char[] {'K'}; //score 5
      _scoreSheet[5] = new char[] {'J', 'X'}; //score 8
      _scoreSheet[6] = new char[] {'Q', 'Z'}; //score 10

      _score=0;
    }

    public int  GetScore() {return _score;}
    public bool ValidateScore(string green)
    {
      foreach (char g in green)
      {
        if (!Char.IsLetter(g))
        {
          return false;
        }
      }
      return true;
    }
    public void SetScore(string green)
    {
      Console.WriteLine(green);

      foreach (char g in green) // itterates through each char in passed string
      {
        for (int i = 0; i < _scoreSheet.Length; i++) //itterates through each arrray in _scoreSheet
        {
          foreach (char c in _scoreSheet[i]) //itterates through each char of _scoreSheet current sub-array
          {
            if (Char.ToUpper(g) == c)
            {
              if (i==5)
              {
                _score=_score+8;
              }
              if (i==6)
              {
                _score=_score+10;
              }
              if(i<5 && i>=0)
              {
                _score=_score+(i+1);
              }
            }
          }
        }
      }
      Console.WriteLine(_score);
    }
  }
}
