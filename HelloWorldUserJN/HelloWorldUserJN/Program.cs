using System;

namespace HelloWorldUserJN
{
    public class Program
    {
        public static ConsoleKey keyPressed;
        public static void Main()
        {
            Console.WriteLine("Hello World!");
            while (keyPressed != ConsoleKey.Enter)
            {
                Console.WriteLine("\n Press the Enter key to end this programm...");
                keyPressed = Console.ReadKey().Key;
            }
        }
    }
}
//Refactored code relates to page 61 of lesson one