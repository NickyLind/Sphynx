using System;
using Sphynx;

namespace RiddleAnswers
{
  public class Answers
  {
    public static bool CorrectAnswerOne(string answer)
    {
      return (answer == "a promise" || answer == "promise" || answer == "your word");
    }
    public static bool CorrectAnswerTwo(string answer)
    {
      return (answer == "an egg" || answer == "egg");
    }
    public static bool CorrectAnswerThree(string answer)
    {
      return (answer == "david");
    }
  }
}