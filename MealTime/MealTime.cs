using System;

class MealTime
{
  static void Main()
  {
    AskWhatYouAteFor("breakfast");
    AskWhatYouAteFor("lunch");
    AskWhatYouAteFor("dinner");
  }

  static void AskWhatYouAteFor(string meal)
  {
    Console.WriteLine("What did you eat for " + meal + "?");
    string userMeal = Console.ReadLine();
    Console.WriteLine("You had " + userMeal + " for " + meal + ".");
  }
}