using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Give me a number and I will double it for you!");
    string stringInput = Console.ReadLine();
    int intInput = int.Parse(stringInput);
    int inputDoubled = intInput * 2;
    string stringDoubled = inputDoubled.ToString();
    Console.WriteLine("I doubled your number for you: " + stringDoubled);
  }
}