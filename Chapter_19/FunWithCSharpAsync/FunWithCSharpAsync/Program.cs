using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithCSharpAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(" Fun With Async ===>");
            //This is to prompt Visual Studio to upgrade project to C# 7.1
            List<int> l = default;
            //Console.WriteLine(DoWork());
            string message = await DoWorkAsync();
            Console.WriteLine(message);
            await MethodReturningVoidAsync();
            Console.WriteLine("Void method complete");
            await MethodReturningVoidAsync();
            await MethodWithProblems(7, -5);
            await MethodWithProblemsFixed(7, -5);
            Console.WriteLine("Completed");
            Console.ReadLine();
        }

        static string DoWork()
        {
            Thread.Sleep(5_000);
            return "Done with work!";
        }

        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5_000);
                return "Done with work!";
            });
        }

        static async Task MethodReturningVoidAsync()
        {
            await Task.Run(() =>
            {
                /* Do some work here... */
                Thread.Sleep(4_000);
            });
            Console.WriteLine("Void method completed");
        }

        static async Task MutliAwaits()
        {
            await Task.Run(() => { Thread.Sleep(2_000); });
            Console.WriteLine("Done with first task!");

            await Task.Run(() => { Thread.Sleep(2_000); });
            Console.WriteLine("Done with second task!");

            await Task.Run(() => { Thread.Sleep(2_000); });
            Console.WriteLine("Done with third task!");
        }

        static async Task<string> MethodWithTryCatch()
        {
            try
            {
                //Do some work
                return "Hello";
            }
            catch (Exception ex)
            {
                await LogTheErrors();
                throw;
            }
            finally
            {
                await DoMagicCleanUp();
            }
        }

        private static Task DoMagicCleanUp()
        {
            throw new NotImplementedException();
        }

        private static Task LogTheErrors()
        {
            throw new NotImplementedException();
        }

        static async Task MethodWithProblems(int firstParam, int secondParam)
        {
            Console.WriteLine("Enter");
            await Task.Run(() =>
            {
                //Call long running method
                Thread.Sleep(4_000);
                Console.WriteLine("First Complete");
                //Call another long running method that fails because
                //the second parameter is out of range
                Console.WriteLine("Something bad happened");
            });
        }

        static async Task MethodWithProblemsFixed(int firstParam, int secondParam)
        {
            Console.WriteLine("Enter");
            if (secondParam < 0)
            {
                Console.WriteLine("Bad data");
                return;
            }

            actualImplementation();

            async Task actualImplementation()
            {
                await Task.Run(() =>
                {
                    //Call long running method
                    Thread.Sleep(4_000);
                    Console.WriteLine("First Complete");
                    //Call another long running method that fails because
                    //the second parameter is out of range
                    Console.WriteLine("Something bad happened");
                });
            }
        }

        static async ValueTask<int> ReturnAnInt()
        {
            await Task.Delay(1_000);
            return 5;
        }
    }
}