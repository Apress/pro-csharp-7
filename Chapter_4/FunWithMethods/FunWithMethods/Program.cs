using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Methods *****\n");

            #region Pass by value
            // Pass two variables in by value.
            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
            Console.WriteLine();
            #endregion

            #region Output params
            // No need to assign initial value to local variables
            // used as output parameters.
            // C# 7 introduces combining the declaration of out parameters in the method call
            Add(90, 90, out int ans);
            Console.WriteLine("90 + 90 = {0}", ans);
            int i;
            string str;
            bool b;

            FillTheseValues(out i, out str, out b);
            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Boolean is: {0}", b);
            Console.WriteLine();
            #endregion

            #region Ref params
            string s1 = "Flip";
            string s2 = "Flop";
            Console.WriteLine("Before: {0}, {1} ", s1, s2);
            SwapStrings(ref s1, ref s2);
            Console.WriteLine("After: {0}, {1} ", s1, s2);
            Console.WriteLine();
            #endregion

            #region Ref locals and params
            string[] stringArray = {"one", "two", "three"};
            int pos = 1;
            Console.WriteLine("=> Use Simple Return");
            Console.WriteLine("Before: {0}, {1}, {2} ", stringArray[0], stringArray[1], stringArray[2]);
            var output = SimpleReturn(stringArray, pos);
            output = "new";
            Console.WriteLine("After: {0}, {1}, {2} ", stringArray[0], stringArray[1], stringArray[2]);
            Console.WriteLine("=> Use Ref Return");
            Console.WriteLine("Before: {0}, {1}, {2} ", stringArray[0], stringArray[1], stringArray[2]);
            ref var refOutput = ref SampleRefReturn(stringArray, pos);
            refOutput = "new";
            Console.WriteLine("After: {0}, {1}, {2} ", stringArray[0], stringArray[1], stringArray[2]);
            Console.WriteLine();
            #endregion

            #region Param array
            // Pass in a comma-delimited list of doubles...
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);

            // ...or pass an array of doubles.
            double[] data = {4.0, 3.2, 5.7};
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);
            Console.WriteLine();

            // Average of 0 is 0!
            Console.WriteLine("Average of data is: {0}", CalculateAverage());
            Console.WriteLine();
            #endregion

            #region Optional arguments / Named arguments
            EnterLogData("Oh no! Grid can't find data");
            EnterLogData("Oh no! I can't find the payroll data", "CFO");
            Console.WriteLine();

            DisplayFancyMessage(message: "Wow!  Very Fancy indeed!",
                textColor: ConsoleColor.DarkRed,
                backgroundColor: ConsoleColor.White);

            DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
                message: "Testing...",
                textColor: ConsoleColor.DarkBlue);

            // This is OK, as positional args are listed before named args.
            DisplayFancyMessage(ConsoleColor.Blue,
                message: "Testing...",
                backgroundColor: ConsoleColor.White);

            // These work only if all args are optional.
            DisplayFancyMessage(message: "Hello!");
            DisplayFancyMessage(backgroundColor: ConsoleColor.Green);
            #endregion

            Console.ReadLine();
        }

        #region Input paramerters
        // Arguments are passed by value by default.
        static int Add(int x, int y)
        {
            int ans = x + y;

            // Caller will not see these changes
            // as you are modifying a copy of the
            // original data.
            x = 10000;
            y = 88888;
            return ans;
        }
        #endregion

        #region Output parameters
        // Output parameters must be assigned by the called method.
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        // Returning multiple output parameters.
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }
        #endregion

        #region Ref parameters
        // Reference parameters.
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
        #endregion

        #region Ref locals and params
        // Returns the value at the array position.
        public static string SimpleReturn(string[] strArray, int position)
        {
            return strArray[position];
        }

        // Returning a reference.
        public static ref string SampleRefReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }

        //Uncomment this to see the compilation error
        //public static ref string ThisWillNotWork(string[] array)
        //{
        //    int foo = 5;
        //    return ref foo;
        //}
        #endregion

        #region Params array
        // Return average of "some number" of doubles.
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;

            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }
        #endregion

        #region Optional arguments
        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

        static void DisplayFancyMessage(ConsoleColor textColor = ConsoleColor.Blue,
            ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test Message")
        {
            // Store old colors to restore once message is printed. 
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;

            // Set new colors and print message.
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;

            Console.WriteLine(message);

            // Restore previous colors. 
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }
        #endregion
    }
}