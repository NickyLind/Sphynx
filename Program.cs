using System;
using RiddleAnswers;

namespace Sphynx
{
  
  public class Questions
  {

    public static void Main()
    {
      Console.WriteLine("'I am the mighty Sphynx answer my question correctly or I will devour you.'");
      Console.WriteLine("'What can you break, even if you never pick it up or touch it?'");
      string answer = Console.ReadLine().ToLower();
      if (Answers.CorrectAnswerOne(answer))
      {
        Console.WriteLine("'You have guessed correctly, your life is spared for now mortal.'");
        Console.WriteLine("'What has to be broken before you use it?'");
        string answerTwo = Console.ReadLine().ToLower();
        if (Answers.CorrectAnswerTwo(answerTwo))
        {
          Console.WriteLine("'Correct again.'");
          Console.WriteLine("'David’s parents have three sons: Snap, Crackle, and what’s the name of the third son?'");
          string answerThree = Console.ReadLine().ToLower();
          if (Answers.CorrectAnswerThree(answerThree))
          {
            Console.WriteLine("'Correct again, I'm starting to get hungry.'");
          }
          else
          {
            Console.WriteLine("You have been eaten by the Sphynx");
          }
        }
        else
        {
          Console.WriteLine("You have been eaten by the Sphynx");
        }
      }
      else
      {
        Console.WriteLine("You have been eaten by the Sphynx");
      }
    }
  }
}