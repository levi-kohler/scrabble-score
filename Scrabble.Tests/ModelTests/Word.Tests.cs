using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_CreateInstanceofWord_Word()
    {
      Word newWord = new Word("test");
      
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void WordConstructor_FindValueOfLetter_Word()
    {
      int Score = Word.GetScore('A');

      Assert.AreEqual(1, Score);
    }
  }
}