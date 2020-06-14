using System;
using System.Transactions;

namespace HelloWorldUserEB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
