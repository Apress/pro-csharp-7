using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Need this to get BigInteger!
using System.Numerics;

namespace BasicDataTypes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Basic Data Types *****\n");
      LocalVarDeclarations();
      DefaultDeclarations();
      NewingDataTypes();
      ObjectFunctionality();
      DataTypeFunctionality();
      CharFunctionality();
      ParseFromStrings();
      ParseFromStringsWithTryParse();
      UseDatesAndTimes();
      UseBigInteger();
      DigitSeparators();
      BinaryLiterals();
      Console.ReadLine();
    }

    #region Local variable declarations

    static void LocalVarDeclarations()
    {
      Console.WriteLine("=> Data Declarations:");
      // Local variables are declared and initialized as follows:
      // dataType varName = initialValue;
      int myInt = 0;

      string myString;
      myString = "This is my character data";

      // Declare 3 bools on a single line.
      bool b1 = true, b2 = false, b3 = b1;

      // Very verbose manner in which to declare a bool.
      System.Boolean b4 = false;

      Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
        myInt, myString, b1, b2, b3, b4);
      Console.WriteLine();
    }
    static void DefaultDeclarations()
    {
      Console.WriteLine("=> Default Declarations:");
      int myInt = default;
    }

    static void NewingDataTypes()
    {
      Console.WriteLine("=> Using new to create variables:");
      bool b = new bool(); // Set to false.
      int i = new int(); // Set to 0.
      double d = new double(); // Set to 0.
      DateTime dt = new DateTime(); // Set to 1/1/0001 12:00:00 AM
      Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
      Console.WriteLine();
    }

    #endregion

    #region Test Object functionality

    static void ObjectFunctionality()
    {
      Console.WriteLine("=> System.Object Functionality:");
      // A C# int is really a shorthand for System.Int32.
      // which inherits the following members from System.Object.
      Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
      Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
      Console.WriteLine("12.ToString() = {0}", 12.ToString());
      Console.WriteLine("12.GetType() = {0}", 12.GetType());
      Console.WriteLine();
    }

    #endregion

    #region Test data type functionality

    static void DataTypeFunctionality()
    {
      Console.WriteLine("=> Data type Functionality:");
      Console.WriteLine("Max of int: {0}", int.MaxValue);
      Console.WriteLine("Min of int: {0}", int.MinValue);
      Console.WriteLine("Max of double: {0}", double.MaxValue);
      Console.WriteLine("Min of double: {0}", double.MinValue);
      Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
      Console.WriteLine("double.PositiveInfinity: {0}",
        double.PositiveInfinity);
      Console.WriteLine("double.NegativeInfinity: {0}",
        double.NegativeInfinity);
      Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
      Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
      Console.WriteLine();
    }

    #endregion

    #region Test char data type

    static void CharFunctionality()
    {
      Console.WriteLine("=> char type Functionality:");
      char myChar = 'a';
      Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
      Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
      Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
        char.IsWhiteSpace("Hello There", 5));
      Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
        char.IsWhiteSpace("Hello There", 6));
      Console.WriteLine("char.IsPunctuation('?'): {0}",
        char.IsPunctuation('?'));
      Console.WriteLine();
    }

    #endregion

    #region Parsing data

    static void ParseFromStrings()
    {
      Console.WriteLine("=> Data type parsing:");
      bool b = bool.Parse("True");
      Console.WriteLine("Value of b: {0}", b);
      double d = double.Parse("99.884");
      Console.WriteLine("Value of d: {0}", d);
      int i = int.Parse("8");
      Console.WriteLine("Value of i: {0}", i);
      char c = Char.Parse("w");
      Console.WriteLine("Value of c: {0}", c);
      Console.WriteLine();
    }

    static void ParseFromStringsWithTryParse()
    {
      Console.WriteLine("=> Data type parsing with TryParse:");
      if (bool.TryParse("True", out bool b)) ;
      {
        Console.WriteLine("Value of b: {0}", b);
      }
      string value = "Hello";
      if (double.TryParse(value, out double d))
      {
        Console.WriteLine("Value of d: {0}", d);
      }
      else
      {
        Console.WriteLine("Failed to convert the input ({0}) to a double", value);
      }
      Console.WriteLine();
    }

    #endregion

    #region Work with dates / times

    static void UseDatesAndTimes()
    {
      Console.WriteLine("=> Dates and Times:");
      // This constructor takes (year, month, day)
      DateTime dt = new DateTime(2015, 10, 17);

      // What day of the month is this?
      Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
      dt = dt.AddMonths(2); // Month is now December.
      Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

      // This constructor takes (hours, minutes, seconds)
      TimeSpan ts = new TimeSpan(4, 30, 0);
      Console.WriteLine(ts);

      // Subtract 15 minutes from the current TimeSpan and
      // print the result.
      Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
      Console.WriteLine();
    }

    #endregion

    #region Use BigInteger

    static void UseBigInteger()
    {
      Console.WriteLine("=> Use BigInteger:");
      BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
      Console.WriteLine("Value of biggy is {0}", biggy);
      Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
      Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
      BigInteger reallyBig = BigInteger.Multiply(biggy,
        BigInteger.Parse("8888888888888888888888888888888888888888888"));
      BigInteger reallyBig2 = biggy * reallyBig;

      Console.WriteLine("Value of reallyBig is {0}", reallyBig);
    }

    #endregion

    #region Use Digit Separators

    static void DigitSeparators()
    {
      Console.WriteLine("=> Use Digit Separators:");
      Console.Write("Integer:");
      Console.WriteLine(123_456);
      Console.Write("Long:");
      Console.WriteLine(123_456_789L);
      Console.Write("Float:");
      Console.WriteLine(123_456.1234F);
      Console.Write("Double:");
      Console.WriteLine(123_456.12);
      Console.Write("Decimal:");
      Console.WriteLine(123_456.12M);
    }

    #endregion

    #region Use Binary Literals

    private static void BinaryLiterals()
    {
      Console.WriteLine("=> Use Binary Literals:");
      Console.WriteLine("Sixteen: {0}", 0b0001_0000);
      Console.WriteLine("Thirty Two: {0}", 0b0010_0000);
      Console.WriteLine("Sixty Four: {0}", 0b0100_0000);
    }

    #endregion
  }
}