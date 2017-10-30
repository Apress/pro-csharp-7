using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("***** Fun with Events *****\n");
            Car c1 = new Car("SlugBug", 100, 10);
            
            // Register event handlers.
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;
            c1.Exploded += CarExploded;
            
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            c1.Exploded -= CarExploded;

            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.ReadLine();
        }

        #region Event handlers
        public static void CarAboutToBlow( string msg )
        { Console.WriteLine(msg); }

        public static void CarIsAlmostDoomed( string msg )
        { Console.WriteLine("=> Critical Message from Car: {0}", msg); }

        public static void CarExploded( string msg )
        { Console.WriteLine(msg); }
        #endregion

        public static void HookIntoEvents()
        {
            Car newCar = new Car();
            newCar.AboutToBlow += NewCar_AboutToBlow;
        }

        private static void NewCar_AboutToBlow(string msgForCaller)
        {
            //Delete the following line and add your code!
            throw new NotImplementedException();
        }
    }
}
