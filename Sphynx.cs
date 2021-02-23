using System;
using Sphynx;

namespace RiddleAnswers
{
  public class Answers
  {
    private int _id;
    private string _question;
    private List <string> _answer = new List<string>{};
    public Riddle(int id, string question, string answer)
    {
      _id=id;
      _question=question;
      _answer=answer;
    }
    // public static int Randomizer()
    // {

    // }
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