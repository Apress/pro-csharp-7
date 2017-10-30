using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Local Functions *****\n");

            // Calls original version of Add()
            Console.WriteLine(Add(10, 10));

            // Calls updated version of Add()
            Console.WriteLine(AddWrapper(10, 10));

            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            //Do some validation here
            return x + y;
        }

        static int AddWrapper(int x, int y)
        {
            //Do some validation here
            return Add();

            int Add()
            {
                return x + y;
            }
        }
    }
}