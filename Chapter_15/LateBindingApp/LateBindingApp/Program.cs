using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace LateBindingApp
{
    // This program will load an external library, 
    // and create an object using late binding.
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Late Binding *****\n");
            // Try to load a local copy of CarLibrary.
            Assembly a = null;
            try
            {
                a = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            if (a != null)
            {
                CreateUsingLateBinding(a);
                InvokeMethodWithArgsUsingLateBinding(a);
            }

            Console.ReadLine();
        }

        #region Invoke method with no args
        static void CreateUsingLateBinding(Assembly asm)
        {
            try
            {
                // Get metadata for the Minivan type.
                Type miniVan = asm.GetType("CarLibrary.MiniVan");

                // Create the Minivan on the fly.
                object obj = Activator.CreateInstance(miniVan);
                Console.WriteLine("Created a {0} using late binding!", obj);

                // Get info for TurboBoost.
                MethodInfo mi = miniVan.GetMethod("TurboBoost");

                // Invoke method ('null' for no parameters).
                mi.Invoke(obj, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Invoke method with args
        static void InvokeMethodWithArgsUsingLateBinding(Assembly asm)
        {
            try
            {
                // First, get a metadata description of the sports car. 
                Type sport = asm.GetType("CarLibrary.SportsCar");

                // Now, create the sports car.
                object obj = Activator.CreateInstance(sport);

                // Invoke TurnOnRadio() with arguments.
                MethodInfo mi = sport.GetMethod("TurnOnRadio");
                mi.Invoke(obj, new object[] { true, 2 });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
