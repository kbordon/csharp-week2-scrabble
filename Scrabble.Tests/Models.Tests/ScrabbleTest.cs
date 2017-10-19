using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void Score_PlayerEntersALetter_AScoreOfOne()
    {
      Game testGame = new Game();
      testGame.SetScore("A");
      Assert.AreEqual(true, testGame.GetScore() == 1);
    }

    [TestMethod]
    public void Score_PlayerSeveralLetters_AScoreOfTwo()
    {
      Game testGame = new Game();
      testGame.SetScore("AA");
      Assert.AreEqual(true, testGame.GetScore() == 2);
    }

    [TestMethod]
    public void Score_PlayerSeveralLettersOfDifferentScoreValues_AScoreOfTwo()
    {
      Game testGame = new Game();
      testGame.SetScore("AB");
      Assert.AreEqual(true, testGame.GetScore() == 4);
    }

    [TestMethod]
    public void Score_PlayerSeveralLettersOfDifferentScoreValues_AScoreOf89()
    {
      Game testGame = new Game();
      testGame.SetScore("Zzyzx");
      Assert.AreEqual(true, testGame.GetScore() == 42);
    }

    [TestMethod]
    public void Score_ValidatePlayerInput_False()
    {
      Game testGame = new Game();
      Assert.AreEqual(false, testGame.ValidateScore("12whoa"));
    }
  }
}
