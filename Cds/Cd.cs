using System;
using System.Collections.Generic;

class Cd
{
  private string _title;
  private string _artist;
  private int _price;

  public void SetTitle(string newTitle)
  {
    _title = newTitle;
  }
  public string GetTitle()
  {
    return _title;
  }

  public void SetArtist(string newArtist)
  {
    _artist = newArtist;
  }
  public string GetArtist()
  {
    return _artist;
  }

  public void SetPrice(int newPrice)
  {
    if (newPrice >= 0)
    {
      _price = newPrice;
    }
    else
    {
      Console.WriteLine(newPrice + " is an invalid price for a cd.");
    }
  }

  public int GetPrice()
  {
    return _price;
  }

  // public Cd(string albumTitle, string albumArtist, int albumPrice)
  // {
  //   _title = albumTitle;
  //   _artist = albumArtist;
  //   _price = albumPrice;
  // }
}

public class Program
{
  static List<Cd> BuildCds()
  {
    Cd firstCd = new Cd();
    firstCd.SetTitle("Dude Ranch");
    firstCd.SetArtist("Blink 182");
    firstCd.SetPrice(10);
    List<Cd> Cds = new List<Cd>() { firstCd };

    return Cds;
  }

  static void PrintCdCollection(List<Cd> Cds)
  {
    foreach (Cd album in Cds)
    {
      Console.WriteLine(album.GetTitle());
      Console.WriteLine("By " + album.GetArtist());
      Console.WriteLine("Price: $" + album.GetPrice());
    }
  }

  public static void Main()
  {
    List<Cd> Cds = BuildCds();
    PrintCdCollection(Cds);
  }
}