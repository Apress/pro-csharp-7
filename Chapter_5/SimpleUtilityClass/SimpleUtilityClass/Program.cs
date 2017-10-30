using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Classes *****\n");

            // This is just fine.
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            // Compiler error! Can't create static classes!
            // TimeUtilClass u = new TimeUtilClass();

            Console.ReadLine();
        }

    }
}
