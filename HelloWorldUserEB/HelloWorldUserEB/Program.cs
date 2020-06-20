using System;
using System.Transactions;

namespace HelloWorldUserEB
{
  public class Program
    {
      public static ConsoleKey KeyPressed;
        public static void Main()
        {
            Console.WriteLine("Hello World!");
            while (KeyPressed != ConsoleKey.Enter) 
                {
                    Console.WriteLine("\nPress the Enter key to end this program...");
                    keyPressed = Console.ReadKey().Key;
            }

        }
    }
}
