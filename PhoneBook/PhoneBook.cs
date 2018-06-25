using System;
using System.Collections.Generic;

class PhoneBook
{
  public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

  static void Main()
  {
    Console.WriteLine("Main Menu");
    Console.WriteLine("Would you like to add a person to your phone book? ['y' for yes, 'Enter' for no] ");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      AddContact();
    }
    else
    {
      Console.WriteLine("Would you like to look up a number in your phone book? ['y' for yes, 'Enter' for no]");
      string lookUpAnswer = Console.ReadLine();
      if (lookUpAnswer == "Y" || lookUpAnswer == "y")
      {
        LookUpContact();
      }
      else
      {
        Console.WriteLine("Are you finished with the program? ['y' for yes, 'Enter' for no]");
        string finishedAnswer = Console.ReadLine();
        if (finishedAnswer == "y" || finishedAnswer == "y")
        {
          Console.WriteLine("Goodbye");
        }
        else
        {
          Main();
        }
      }
    }
  }

  static void AddContact()
  {
    Console.WriteLine("New Contact");
    Console.WriteLine("Enter the new contact's name:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter the new contact's phone number:");
    string number = Console.ReadLine();
    if (phoneNumbers.ContainsKey(name))
    {
      Console.WriteLine(phoneNumbers[name] + " already exists in your phonebook. Their number is " + phoneNumbers[name]);
    }
    else
    {
      phoneNumbers.Add(name, number);
    }
    Main();
  }

  static void LookUpContact()
  {
    Console.WriteLine("Contact Lookup");
    Console.WriteLine("Who's number would you like to look up?");
    string friend = Console.ReadLine();
    if (phoneNumbers.ContainsKey(friend))
    {
      string number = phoneNumbers[friend];
      Console.WriteLine(friend + "\'s phone number is " + number);
    }
    else
    {
      Console.WriteLine("That person is not in your phone book.");
    }
    Main();
  }
}
