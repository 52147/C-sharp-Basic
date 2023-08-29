using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Starting...");

        string result = await FetchDataAsync();
        
        Console.WriteLine($"Data fetched: {result}");

        Console.WriteLine("End.");
    }

    // This method simulates an asynchronous operation
    public static async Task<string> FetchDataAsync()
    {
        await Task.Delay(2000);  // Simulate waiting for data for 2 seconds
        return "Sample Data";
    }
}

