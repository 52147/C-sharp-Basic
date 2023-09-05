using System;
using System.Threading;
using System.Threading.Tasks;

public class TaskExamples
{
    public void BasicUsage()
    {
        Task.Run(() =>
        {
            // Do some work here
            Console.WriteLine("Basic task executed.");
        });
    }

    public async Task<int> TaskWithReturnValue()
    {
        Task<int> task = Task.Run(() =>
        {
            return 42;
        });
        int result = await task;
        return result;
    }

    public async Task HandleExceptionsAsync()
    {
        Task task = Task.Run(() =>
        {
            throw new InvalidOperationException("An error occurred.");
        });

        try
        {
            await task;
        }
        catch (AggregateException ae)
        {
            // Handle exceptions here
            foreach (var e in ae.InnerExceptions)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public async Task CombineMultipleTasks()
    {
        var task1 = DoWorkAsync("Task1");
        var task2 = DoWorkAsync("Task2");

        await Task.WhenAll(task1, task2);
    }

    public async Task TaskContinuation()
    {
        var task = DoWorkAsync("Continuation Task");
        await task.ContinueWith(t =>
        {
            // This block runs after the task completes
            Console.WriteLine("Task has completed.");
        });
    }

    public void TaskWithCancellation()
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var token = cancellationTokenSource.Token;

        var task = Task.Run(() => 
        {
            // Periodically check for cancellation
            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    // Clean up resources if necessary
                    token.ThrowIfCancellationRequested();
                }

                // Continue doing work
                Console.WriteLine("Working...");
                Thread.Sleep(500); // Simulate work
            }
        }, token);

        // For demonstration purposes, cancel after 2 seconds
        Thread.Sleep(2000);
        cancellationTokenSource.Cancel();
    }

    private async Task DoWorkAsync(string taskName)
    {
        await Task.Delay(1000); // Simulate some async work
        Console.WriteLine($"{taskName} completed.");
    }
}
