using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("***** Fun with Anonymous Types *****\n");

            // Make an anonymous type representing a car using hard coded data. 
            var myCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            // Reflect over what the compiler generated.
            ReflectOverAnonymousType(myCar);

            // Now show the color and make.
            Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Make);

            // Now call our helper method to build anonymous type via args. 
            BuildAnonType("BMW", "Black", 90);

            EqualityTest();

            Console.ReadLine();
        }

        static void BuildAnonType( string make, string color, int currSp )
        {
            // Build anon type using incoming args. 
            var car = new { Make = make, Color = color, Speed = currSp };

            // Note you can now use this type to get the property data!
            Console.WriteLine("You have a {0} {1} going {2} MPH",
              car.Color, car.Make, car.Speed);

            // Anon types have custom implementations of each virtual 
            // method of System.Object. For example:
            Console.WriteLine("ToString() == {0}", car.ToString());
        }

        static void ReflectOverAnonymousType( object obj )
        {
            Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}", obj.GetType().Name, obj.GetType().BaseType);
            Console.WriteLine("obj.ToString() == {0}", obj.ToString());
            Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());
            Console.WriteLine();
        }

        static void EqualityTest()
        {
            // Make 2 anonymous classes with identical name/value pairs.
            var firstCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            var secondCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            // Are they considered equal when using Equals()?
            if (firstCar.Equals(secondCar))
                Console.WriteLine("Same anonymous object!");
            else
                Console.WriteLine("Not the same anonymous object!");

            // Are they considered equal when using ==?
            if (firstCar == secondCar)
                Console.WriteLine("Same anonymous object!");
            else
                Console.WriteLine("Not the same anonymous object!");

            // Are these objects the same underlying type?
            if (firstCar.GetType().Name == secondCar.GetType().Name)
                Console.WriteLine("We are both the same type!");
            else
                Console.WriteLine("We are different types!");

            // Show all the details.
            Console.WriteLine();
            ReflectOverAnonymousType(firstCar);
            ReflectOverAnonymousType(secondCar);
        }

    }
}
