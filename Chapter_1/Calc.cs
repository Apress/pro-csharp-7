// Calc.cs
using System;
namespace CalculatorExample
{
  // This class contains the app's entry point.
  class Program
  {
    static void Main()
    {
      Calc c = new Calc();
      int ans = c.Add(10, 84);
      Console.WriteLine("10 + 84 is {0}.", ans);
      // Wait for user to press the Enter key before shutting down.
      Console.ReadLine();
    }
  }

  // The C# calculator.
  class Calc
  {
    public int Add(int x, int y)
    { return x + y; }
  }
}
