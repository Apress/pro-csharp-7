using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFinalize
{
    // Override System.Object.Finalize() via finalizer syntax.
    class MyResourceWrapper
    {
        // Clean up unmanaged resources here.
        // Beep when destroyed (testing purposes only!)
        ~MyResourceWrapper() => Console.Beep();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Finalizers *****\n");
            Console.WriteLine("Hit the return key to shut down this app");
            Console.WriteLine("and force the GC to invoke Finalize()");
            Console.WriteLine("for finalizable objects created in this AppDomain.");
            Console.ReadLine();
            MyResourceWrapper rw = new MyResourceWrapper();
        }
    }
}