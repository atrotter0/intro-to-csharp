using System;

class AlwaysOne
{
  static void Main()
  {
    Console.WriteLine("Give me any number.");
    Console.WriteLine("I will magically turn that number into 1!");
    string stringNumber = Console.ReadLine();
    int intNumber = int.Parse(stringNumber);
    int theNumberOne = intNumber / intNumber;
    string stringNumberOne = theNumberOne.ToString();
    Console.WriteLine("Aba cadabra! " + stringNumberOne);
  }
}