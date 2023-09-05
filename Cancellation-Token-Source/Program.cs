class Program
{
    static async Task Main(string[] args)
    {
        var tokenExamples = new CancellationTokenDemoExample();

        // Test CancellationTokenDemo
        tokenExamples.CancellationTokenDemo();

        // Test CancelAfterDelayDemo
        tokenExamples.CancelAfterDelayDemo();

        Console.WriteLine("All demos completed. Press any key to exit.");
        Console.ReadKey();
    }
}

