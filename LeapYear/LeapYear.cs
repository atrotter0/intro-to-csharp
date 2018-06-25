using System;

class LeapYear
{
  static void Main()
  {
    const int CURRENT_YEAR = 2018;

    Console.WriteLine("What year were you born?");
    string stringYear = Console.ReadLine();
    int intYear = int.Parse(stringYear);

    Console.WriteLine("You were alive during these leap years:");
    for (int year = intYear; year < CURRENT_YEAR; year++)
    {
      if (year % 4 == 0)
      {
        Console.WriteLine(year);
      }
    }
  }
}