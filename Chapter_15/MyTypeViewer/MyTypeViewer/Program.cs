using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

namespace MyTypeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to MyTypeViewer *****");
            string typeName = "";

            do
            {
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.Write("or enter Q to quit: ");

                // Get name of type.
                typeName = Console.ReadLine();

                // Does user want to quit?
                if (typeName.Equals("Q",StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                // Try to display type.
                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine("");
                    ListVariousStats(t);
                    ListFields(t);
                    ListProps(t);
                    ListMethods(t);
                    ListInterfaces(t);
                }
                catch
                {
                    Console.WriteLine("Sorry, can't find type");
                }
            } while (true);
        }

        #region Helper methods

        #region Simple version of ListMethods
        // Display method names of type.
        //static void ListMethods(Type t)
        //{
        //    Console.WriteLine("***** Methods *****");
        //    var methodNames = from n in t.GetMethods() select n.Name;
        //    foreach (var name in methodNames)
        //        Console.WriteLine("->{0}", name);
        //    Console.WriteLine();
        //}
        #endregion

        #region Complex version of ListMethods (No LINQ)
        //static void ListMethods(Type t)
        //{
        //    Console.WriteLine("***** Methods *****");
        //    MethodInfo[] mi = t.GetMethods();
        //    foreach (MethodInfo m in mi)
        //    {
        //        // Get return value.
        //        string retVal = m.ReturnType.FullName;
        //        string paramInfo = "( ";

        //        // Get params.
        //        foreach (ParameterInfo pi in m.GetParameters())
        //        {
        //            paramInfo += string.Format("{0} {1} ", pi.ParameterType, pi.Name);
        //        }
        //        paramInfo += " )";

        //        // Now display the basic method sig.
        //        Console.WriteLine("->{0} {1} {2}", retVal, m.Name, paramInfo);
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        // Display method names of type.
        static void ListMethods(Type t)
        {
            Console.WriteLine("***** Methods *****");
            var methodNames = from n in t.GetMethods() select n;
            foreach (var name in methodNames)
                Console.WriteLine("->{0}", name);
            Console.WriteLine();
        }

        // Display field names of type.
        static void ListFields(Type t)
        {
            Console.WriteLine("***** Fields *****");
            var fieldNames = from f in t.GetFields() select f.Name;
            foreach (var name in fieldNames)
                Console.WriteLine("->{0}", name);
            Console.WriteLine();
        }

        // Display property names of type.
        static void ListProps(Type t)
        {
            Console.WriteLine("***** Properties *****");
            var propNames = from p in t.GetProperties() select p.Name;
            foreach (var name in propNames)
                Console.WriteLine("->{0}", name);
            Console.WriteLine();
        }

        // Display implemented interfaces.
        static void ListInterfaces(Type t)
        {
            Console.WriteLine("***** Interfaces *****");
            var ifaces = from i in t.GetInterfaces() select i;
            foreach (Type i in ifaces)
                Console.WriteLine("->{0}", i.Name);
        }

        // Just for good measure.
        static void ListVariousStats(Type t)
        {
            Console.WriteLine("***** Various Statistics *****");
            Console.WriteLine("Base class is: {0}", t.BaseType);
            Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
            Console.WriteLine("Is type sealed? {0}", t.IsSealed);
            Console.WriteLine("Is type generic? {0}", t.IsGenericTypeDefinition);
            Console.WriteLine("Is type a class type? {0}", t.IsClass);
            Console.WriteLine();
        }
        #endregion
    }
}
