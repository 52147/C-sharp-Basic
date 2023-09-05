class Program
{
    static async Task Main(string[] args)
    {
        var examples = new TaskExamples();

        Console.WriteLine("Executing Basic Usage:");
        examples.BasicUsage();
        Thread.Sleep(2000);  // Wait a bit to let the task execute

        Console.WriteLine("\nExecuting Task With Return Value:");
        int value = await examples.TaskWithReturnValue();
        Console.WriteLine($"Returned value: {value}");

        Console.WriteLine("\nExecuting Handle Exceptions:");
        try
        {
            await examples.HandleExceptionsAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught exception in Main: {ex.Message}");
        }

        Console.WriteLine("\nExecuting Combine Multiple Tasks:");
        await examples.CombineMultipleTasks();

        Console.WriteLine("\nExecuting Task Continuation:");
        await examples.TaskContinuation();

        Console.WriteLine("\nExecuting Task With Cancellation:");
        examples.TaskWithCancellation();

        Console.WriteLine("\nAll demonstrations complete.");
    }
}

