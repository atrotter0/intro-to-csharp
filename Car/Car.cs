using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return (Price < maxPrice && Miles < maxMiles);
  }
}

public class Program
{ 
  static List<Car> BuildCars()
  {
    Car porsche = new Car();
    porsche.MakeModel = "2014 Porsche 911";
    porsche.Price = 114991;
    porsche.Miles = 7864;

    Car ford = new Car();
    ford.MakeModel = "2011 Ford F450";
    ford.Price = 55995;
    ford.Miles = 14241;

    Car lexus = new Car();
    lexus.MakeModel = "2013 Lexus RX 350";
    lexus.Price = 44700;
    lexus.Miles = 20000;

    Car mercedes = new Car();
    mercedes.MakeModel = "Mercedes Benz CLS550";
    mercedes.Price = 39900;
    mercedes.Miles = 37979;

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
    return Cars;
  }

  static void PrintCars(List<Car> Cars)
  {
    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }

  static int PromptUserForPrice()
  {
    Console.WriteLine("Enter maximum price to search through our car listings: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);
    return maxPrice;
  }

  static List<Car> SearchCars(List<Car> Cars, int maxPrice)
  {
    List<Car> CarsMatchingSearch = new List<Car>();
    foreach (Car automobile in Cars)
    {
      if (automobile.Price < maxPrice)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    return CarsMatchingSearch;
  }

  static void PrintSearchResults(List<Car> CarsMatchingSearch)
  {
    if (CarsMatchingSearch.Count == 0)
    {
      PrintNoMatchesFound();
    }
    else
    {
      Console.WriteLine("Here are our matches we found based on your maximum price:");
      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.MakeModel);
      }
    }
  }

  static void PrintNoMatchesFound()
  {
    Console.WriteLine("Sorry, no matches were found based on your maximum price.");
  }

  public static void Main()
  {
    List<Car> Cars = BuildCars();
    PrintCars(Cars);
    int userMaxPrice = PromptUserForPrice();
    List<Car> MatchingCars = SearchCars(Cars, userMaxPrice);
    PrintSearchResults(MatchingCars);
  }
}
