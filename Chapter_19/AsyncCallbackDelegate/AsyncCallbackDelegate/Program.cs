using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace AsyncCallbackDelegate
{
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        private static bool isDone = false;

        static void Main(string[] args)
        {
            Console.WriteLine("*****  AsyncCallbackDelegate Example *****");
            Console.WriteLine("Main() invoked on thread {0}.",
              Thread.CurrentThread.ManagedThreadId);

            BinaryOp b = new BinaryOp(Add);
            IAsyncResult ar = b.BeginInvoke(10, 10,
              new AsyncCallback(AddComplete),
              "Main() thanks you for adding these numbers.");

            // Assume other work is performed here...
            while (!isDone)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Working....");
            }

            Console.ReadLine();
        }

        #region Target for AsyncCallback delegate
        // Don't forget to add a 'using' directive for 
        // System.Runtime.Remoting.Messaging!
        static void AddComplete(IAsyncResult iar)
        {
            Console.WriteLine("AddComplete() invoked on thread {0}.",
              Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Your addition is complete");

            // Now get the result.
            AsyncResult ar = (AsyncResult)iar;
            BinaryOp b = (BinaryOp)ar.AsyncDelegate;
            Console.WriteLine("10 + 10 is {0}.", b.EndInvoke(iar));

            // Retrieve the informational object and cast it to string.
            string msg = (string)iar.AsyncState;
            Console.WriteLine(msg);

            isDone = true;
        }

        #endregion

        #region Target for BinaryOp delegate
        static int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}.",
              Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }
        #endregion
    }
}

