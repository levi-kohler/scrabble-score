using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Program
{
  public class Program
  {
public static void Main()
    {
  Console.WriteLine("Welcome to the Scrabble Score Calculator. Input a word and we'll tell you how many points it is!");
  string userInput = Console.ReadLine();
  Word newWord = new Word(userInput);
  char[] wordArray = newWord.LoopWord(userInput);
  Console.WriteLine(newWord);
  // int score = newWord.GetScore(wordArray)
    }
  }
}