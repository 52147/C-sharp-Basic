using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Number of command-line arguments: " + args.Length);
        for (int i = 0; i < args.Length; i++) {
            Console.WriteLine($"Argument {i + 1}: {args[i]}");
        }
    }
}