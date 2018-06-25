using System;

class Rectangle
{
  public int Length;
  public int Width;

  public bool IsSquare()
  {
    if (Length == Width)
    {
      return true;
    }
    else 
    {
      return false;
    }
  }

  public int GetArea()
  {
    return Length * Width;
  }
}

public class Program
{
  public static void Main()
  {
    Rectangle myRectangle = new Rectangle();

    Console.WriteLine("Enter the length: ");
    string stringLength = Console.ReadLine();
    int myLength = int.Parse(stringLength);
    myRectangle.Length = myLength;

    Console.WriteLine("Enter the width: ");
    string stringWidth = Console.ReadLine();
    int myWidth = int.Parse(stringWidth);
    myRectangle.Width = myWidth;

    if (myRectangle.IsSquare())
    {
      Console.WriteLine("Congratulations! You made a square!");
    } 
    else 
    {
      Console.WriteLine("Sorry! This isn't a square.");
    }
    Console.WriteLine("The area of your rectangle is " + myRectangle.GetArea());
  }
}
