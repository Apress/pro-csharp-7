using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Import the static members of Console and DateTime.
using static System.Console;
using static System.DateTime;

namespace SimpleUtilityClass
{
    #region First version of utility class. 
    // Static classes can only
    // contain static members!
    /*
    static class TimeUtilClass
    {
        public static void PrintTime()
        { Console.WriteLine(DateTime.Now.ToShortTimeString()); }

        public static void PrintDate()
        { Console.WriteLine(DateTime.Today.ToShortDateString()); }
    }
    */
    #endregion

    static class TimeUtilClass
    {
        public static void PrintTime() => WriteLine(Now.ToShortTimeString()); 

        public static void PrintDate() => WriteLine(Today.ToShortDateString());
    }
}
