using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DefaultAppDomainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the default app domain *****\n");
            InitDAD();
            DisplayDADStats();
            ListAllAssembliesInAppDomain();
            Console.ReadLine();
        }

        #region Display stats of default app domain
        private static void DisplayDADStats()
        {
            // Get access to the app domain for the current thread.

            AppDomain defaultAD = AppDomain.CurrentDomain;

            // Print out various stats about this domain.
            Console.WriteLine("Name of this domain: {0}", defaultAD.FriendlyName);
            Console.WriteLine("ID of domain in this process: {0}", defaultAD.Id);
            Console.WriteLine("Is this the default domain?: {0}", defaultAD.IsDefaultAppDomain());
            Console.WriteLine("Base directory of this domain: {0}", defaultAD.BaseDirectory);
        }
        #endregion

        #region List ASMS in app domain
        static void ListAllAssembliesInAppDomain()
        {
            // Get access to the app domain for the current thread.
            AppDomain defaultAD = AppDomain.CurrentDomain;

            // Now get all loaded assemblies in the default app domain. 
            var loadedAssemblies = from a in defaultAD.GetAssemblies()
                                   orderby a.GetName().Name
                                   select a;

            Console.WriteLine("***** Here are the assemblies loaded in {0} *****\n",
                defaultAD.FriendlyName);
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine("-> Name: {0}", a.GetName().Name);
                Console.WriteLine("-> Version: {0}\n", a.GetName().Version);
            }
        }
        #endregion

        static void InitDAD()
        {
            // This logic will print out the name of any assembly
            // loaded into the applicaion domain, after it has been
            // created. 
            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.AssemblyLoad += (o, s) =>
            {
                Console.WriteLine("{0} has been loaded!", s.LoadedAssembly.GetName().Name);
            };
        }
    }
}
