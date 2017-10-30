using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AttributedCarLibrary;

namespace VehicleDescriptionAttributeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
            ReflectOnAttributesWithEarlyBinding();
            Console.ReadLine();
        }

        private static void ReflectOnAttributesWithEarlyBinding()
        {
            // Get a Type representing the Winnebago.
            Type t = typeof(Winnebago);

            // Get all attributes on the Winnebago.
            object[] customAtts = t.GetCustomAttributes(false);

            // Print the description.
            foreach (VehicleDescriptionAttribute v in customAtts)
                Console.WriteLine("-> {0}\n", v.Description);
        }
    }
}
