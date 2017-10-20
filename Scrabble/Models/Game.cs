using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble.Models
{
  public class Game
  {
    static private char[][] _scoreSheet = new char[7][];
    private int _score;
    private List<char> _userWord = new List<char>{};
    private List<int> _letterScore = new List<int>{};

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

    public int GetScore() {return _score;}
    public List<char> GetUserWord()
    {
      return _userWord;
    }
    public List<int> GetLetterScore()
    {
      return _letterScore;
    }
    public bool ValidateInput(string green)
    {
      foreach (char g in green)
      {
        if (!Char.IsLetter(g))
        {
          return false;
        }
      }
      foreach (char g in green.ToUpper())
      {
        _userWord.Add(g);
      }
      // _userWord = green;
      return true;
    }
    public void SetScore(string green)
    {
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
                _letterScore.Add(8);
              }
              if (i==6)
              {
                _score=_score+10;
                _letterScore.Add(10);
              }
              if(i<5 && i>=0)
              {
                _score=_score+(i+1);
                _letterScore.Add(i+1);
              }
            }
          }
        }
      }
    }
  }
}
