using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace AppConfigReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Reading <appSettings> Data *****\n");

            // Get our custom data from the *.config file. 
            AppSettingsReader ar = new AppSettingsReader();
            int numbOfTimes = (int)ar.GetValue("RepeatCount", typeof(int));
            string textColor = (string)ar.GetValue("TextColor", typeof(string));

            Console.ForegroundColor =
              (ConsoleColor)Enum.Parse(typeof(ConsoleColor), textColor);

            // Now print a message correctly. 
            for (int i = 0; i < numbOfTimes; i++)
                Console.WriteLine("Howdy!");
            Console.ReadLine();
        }
    }
}
