using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with the Yield Keyword *****\n");

      Garage carLot = new Garage();
      //Next line demonstrates the delayed error error
      //IEnumerator carEnumerator = carLot.GetEnumerator();

      // Get items using GetEnumerator().
      foreach (Car c in carLot)
      {
        Console.WriteLine("{0} is going {1} MPH",
          c.PetName, c.CurrentSpeed);
      }

      Console.WriteLine();

      // Get items (in reverse!) using named iterator.
      foreach (Car c in carLot.GetTheCars(true))
      {
        Console.WriteLine("{0} is going {1} MPH",
          c.PetName, c.CurrentSpeed);
      }
      Console.ReadLine();
    }
  }
}