using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Tuples *****\n");
            Console.WriteLine("=> First Example");
            (string, int, string) values = ("a", 5, "c");
            Console.WriteLine($"First item: {values.Item1}");
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}");
            Console.WriteLine();

            Console.WriteLine("=> Using Named Properties");
            (string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");
            Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");
            //Using the item notation still works!
            Console.WriteLine($"First item: {valuesWithNames.Item1}");
            Console.WriteLine($"Second item: {valuesWithNames.Item2}");
            Console.WriteLine($"Third item: {valuesWithNames.Item3}");
            Console.WriteLine();
            //Naming on the right
            var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");
            Console.WriteLine($"First item: {valuesWithNames2.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames2.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames2.SecondLetter}");
            Console.WriteLine();
            //Naming on both sides doesn't work
            (int Field1, int Field2) example = (Custom1:5, Custom2:7);
            //This next line won't even compile. Uncomment it to see the error.
            //Console.WriteLine($"Another test {example.Custom1}");

            Console.WriteLine("=> Inferred Tuple Names");
            var foo = new {Prop1 = "first", Prop2 = "second"};
            var bar = (foo.Prop1, foo.Prop2);
            Console.WriteLine($"{bar.Prop1};{bar.Prop2}");

            Console.WriteLine("=> Tuples as Return Values");
            var samples = FillTheseValues();
            Console.WriteLine($"Int is: {samples.a}");
            Console.WriteLine($"String is: {samples.b}");
            Console.WriteLine($"Boolean is: {samples.c}");
            Console.WriteLine();
            var (first, _, last) = SplitNames("Philip F Japikse");
            Console.WriteLine($"{first} {last}");
            Console.WriteLine();
            Console.WriteLine("=> Deconstructing Tuples");
            Point p = new Point(7,5);
            var pointValues = p.Deconstruct();
            Console.WriteLine($"X is: {pointValues.XPos}");
            Console.WriteLine($"Y is: {pointValues.YPos}");
            Console.WriteLine();


            Console.ReadLine();
        }
        #region Using a tuple instead of multiple output parameters
        static (int a,string b,bool c) FillTheseValues()
        {
            return (9,"Enjoy your string.",true);
        }
        static (string first, string middle, string last) SplitNames(string fullName)
        {
            //do what is needed to split the name apart
            return ("Philip", "F", "Japikse");
        }
        #endregion

        #region Simple structure
        struct Point
        {
            // Fields of the structure.
            public int X;
            public int Y;

            // A custom constructor.
            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }

            public (int XPos, int YPos) Deconstruct() => (X, Y);
        }
        #endregion

    }
}