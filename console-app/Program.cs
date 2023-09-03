using System;

namespace ConsoleAppExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you, {name}!");
        }
    }
}

