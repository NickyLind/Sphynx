using System;
using RiddleAnswers;

namespace Sphynx
{
  
  public class Questions
  {

    public static void Main()
    {
      Console.WriteLine("'I am the mighty Sphynx answer my question correctly or I will devour you.'");
      List <string> RidOneAnswers = new List <string> {"a promise", "promise", "your word"};
      Riddle riddleOne = new Riddle(1,"'What can you break, even if you never pick it up or touch it?'", RidOneAnswers);
      List <string> RidTwoAnswers = new List <string> {"an egg", "egg"};
      Riddle riddleTwo = new Riddle(2,"'What has to be broken before you use it?'", RidTwoAnswers);
      List <string> RidThreeAnswers = new List<string> {"david"};
      Riddle riddleThree = new Riddle(3,"'David’s parents have three sons: Snap, Crackle, and what’s the name of the third son?'", RidThreeAnswers);
      Console.WriteLine(riddleOne.answer[1]);
      
      List<Riddle> Riddles = new List<Riddle>{riddleOne, riddleTwo, riddleThree};
    }
  }
}





