using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDispose
{
    #region A disposable object
    // Implementing IDisposable.
    class MyResourceWrapper : IDisposable
    {
        // The object user should call this method
        // when they finish with the object.
        public void Dispose()
        {
            // Clean up unmanaged resources...

            // Dispose other contained disposable objects...

            // Just for a test.
            Console.WriteLine("***** In Dispose! *****");
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Dispose *****\n");

            // Use a comma-delimited list to declare multiple objects to dispose.
            using (MyResourceWrapper rw = new MyResourceWrapper(),
                                    rw2 = new MyResourceWrapper())
            {
                // Use rw and rw2 objects.
            }
            Console.ReadLine();
        }
    }
}
