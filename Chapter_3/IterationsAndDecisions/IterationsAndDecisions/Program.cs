using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IterationsAndDecisions
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Loops and Choices *****\n");
      //ForAndForEachLoop();
      //VarInForeachLoop();
      //ExecuteWhileLoop();
      //ExecuteDoWhileLoop();
      //ExecuteIfElse();
      //ExecuteIfElseUsingConditionalOperator();
      //ExecuteSwitch();
      //ExecuteSwitchOnString();
      //SwitchOnEnumExample();
      //ExecutePatternMatchingSwitch();
      ExecutePatternMatchingSwitchWithWhen();
      Console.ReadLine();
    }

    #region For / foreach loops

    // A basic for loop.
    static void ForAndForEachLoop()
    {
      // Note! "i" is only visible within the scope of the for loop.
      for (int i = 0; i < 4; i++)
      {
        Console.WriteLine("Number is: {0} ", i);
      }
      // "i" is not visible here.
      Console.WriteLine();

      string[] carTypes = {"Ford", "BMW", "Yugo", "Honda"};
      foreach (string c in carTypes)
        Console.WriteLine(c);
      Console.WriteLine();

      int[] myInts = {10, 20, 30, 40};
      foreach (int i in myInts)
        Console.WriteLine(i);

      Console.WriteLine();
    }

    #endregion

    #region Var keyword in foreach

    static void VarInForeachLoop()
    {
      int[] myInts = {10, 20, 30, 40};

      // Use "var" in a standard foreach loop.
      foreach (var item in myInts)
      {
        Console.WriteLine("Item value: {0}", item);
      }

      Console.WriteLine();
    }

    #endregion

    #region while loop

    static void ExecuteWhileLoop()
    {
      string userIsDone = "";

      // Test on a lower-class copy of the string.
      while (userIsDone.ToLower() != "yes")
      {
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
        Console.WriteLine("In while loop");
      }
      Console.WriteLine();
    }

    #endregion

    #region do/while loop

    static void ExecuteDoWhileLoop()
    {
      string userIsDone = "";

      do
      {
        Console.WriteLine("In do/while loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
      } while (userIsDone.ToLower() != "yes"); // Note the semicolon!

      Console.WriteLine();
    }

    #endregion

    #region If/else

    static void ExecuteIfElse()
    {
      string stringData = "My textual data";
      if (stringData.Length > 0)
      {
        Console.WriteLine("string is greater than 0 characters");
      }
      else
      {
        Console.WriteLine("string is not greater than 0 characters");
      }
      Console.WriteLine();
    }

    private static void ExecuteIfElseUsingConditionalOperator()
    {
      string stringData = "My textual data";
      Console.WriteLine(stringData.Length > 0
        ? "string is greater than 0 characters"
        : "string is not greater than 0 characters");
      Console.WriteLine();
    }

    #endregion

    #region C# 6 switch statements

    // Switch on a numerical value.
    static void ExecuteSwitch()
    {
      Console.WriteLine("1 [C#], 2 [VB]");
      Console.Write("Please pick your language preference: ");

      string langChoice = Console.ReadLine();
      int n = int.Parse(langChoice);

      switch (n)
      {
        case 1:
          Console.WriteLine("Good choice, C# is a fine language.");
          break;
        case 2:
          Console.WriteLine("VB: OOP, multithreading, and more!");
          break;
        default:
          Console.WriteLine("Well...good luck with that!");
          break;
      }
      Console.WriteLine();
    }

    static void ExecuteSwitchOnString()
    {
      Console.WriteLine("C# or VB");
      Console.Write("Please pick your language preference: ");
      string langChoice = Console.ReadLine();
      switch (langChoice)
      {
        case "C#":
          Console.WriteLine("Good choice, C# is a fine language.");
          break;
        case "VB":
          Console.WriteLine("VB: OOP, multithreading and more!");
          break;
        default:
          Console.WriteLine("Well...good luck with that!");
          break;
      }
      Console.WriteLine();
    }

    static void SwitchOnEnumExample()
    {
      Console.Write("Enter your favorite day of the week: ");
      DayOfWeek favDay;

      try
      {
        favDay = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
      }
      catch (Exception)
      {
        Console.WriteLine("Bad input!");
        return;
      }

      switch (favDay)
      {
        case DayOfWeek.Sunday:
          Console.WriteLine("Football!!");
          break;
        case DayOfWeek.Monday:
          Console.WriteLine("Another day, another dollar");
          break;
        case DayOfWeek.Tuesday:
          Console.WriteLine("At least it is not Monday");
          break;
        case DayOfWeek.Wednesday:
          Console.WriteLine("A fine day.");
          break;
        case DayOfWeek.Thursday:
          Console.WriteLine("Almost Friday...");
          break;
        case DayOfWeek.Friday:
          Console.WriteLine("Yes, Friday rules!");
          break;
        case DayOfWeek.Saturday:
          Console.WriteLine("Great day indeed.");
          break;
      }
      Console.WriteLine();
    }

    public static void SwitchWithGoto()
    {
      var foo = 5;
      switch (foo)
      {
        case 1:
          //do something
          goto case 2;
        case 2:
          //do something else
          break;
        case 3:
          //yet another action
          goto default;
        default:
          //default action
          break;
      }
    }

    #endregion

    #region C# 7 switch statements

    static void ExecutePatternMatchingSwitch()
    {
      Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
      Console.Write("Please choose an option: ");
      string userChoice = Console.ReadLine();
      object choice;
      //This is a standard constant pattern switch statement to set up the example
      switch (userChoice)
      {
        case "1":
          choice = 5;
          break;
        case "2":
          choice = "Hi";
          break;
        case "3":
          choice = 2.5;
          break;
        default:
          choice = 5;
          break;
      }
      //This is new the pattern matching switch statement
      switch (choice)
      {
        case int i:
          Console.WriteLine("Your choice is an integer {0}.",i);
          break;
        case string s:
          Console.WriteLine("Your choice is a string. {0}", s);
          break;
        case decimal d:
          Console.WriteLine("Your choice is a decimal. {0}", d);
          break;
        default:
          Console.WriteLine("Your choice is something else");
          break;
      }
      Console.WriteLine();
    }

static void ExecutePatternMatchingSwitchWithWhen()
{
  Console.WriteLine("1 [C#], 2 [VB]");
  Console.Write("Please pick your language preference: ");

  object langChoice = Console.ReadLine();
  var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

  switch (choice)
  {
    case int i when i == 2:
    case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
      Console.WriteLine("VB: OOP, multithreading, and more!");
      break;
    case int i when i == 1:
    case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
      Console.WriteLine("Good choice, C# is a fine language.");
      break;
    default:
      Console.WriteLine("Well...good luck with that!");
      break;
  }
  Console.WriteLine();
}

    #endregion
  }
}