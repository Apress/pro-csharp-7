using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExtensions
{
    static class AnnoyingExtensions
    {
        public static void PrintDataAndBeep(this System.Collections.IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
                Console.Beep();
            }
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("***** Extending Interface Compatible Types *****\n");

            // System.Array implements IEnumerable!
            string[] data = { "Wow", "this", "is", "sort", "of", "annoying",
                              "but", "in", "a", "weird", "way", "fun!"};

            data.PrintDataAndBeep();

            Console.WriteLine();

            // List<T> implements IEnumerable!
            List<int> myInts = new List<int>() { 10, 15, 20 }; 
            myInts.PrintDataAndBeep();

            Console.ReadLine();
        }
    }
}
