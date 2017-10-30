using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Method Overloading *****\n");

            // Calls int version of Add()
            Console.WriteLine(Add(10, 10));

            // Calls long version of Add() (using the new digit separator)
            Console.WriteLine(Add(900_000_000_000, 900_000_000_000));

            // Calls double version of Add()
            Console.WriteLine(Add(4.3, 4.4));

            Console.ReadLine();
        }

        #region Overloaded Add() methods
        // Overloaded Add() method.
        static int Add(int x, int y)
        { return x + y; }

        static double Add(double x, double y)
        { return x + y; }

        static long Add(long x, long y)
        { return x + y; }
        #endregion
    }
}
