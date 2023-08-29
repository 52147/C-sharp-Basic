using System;

class Program {
    static int Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("No arguments provided.");
            return 1; // Indicate an error
        } else {
            Console.WriteLine($"First argument: {args[0]}");
            return 0; // Indicate success
        }
    }
}
