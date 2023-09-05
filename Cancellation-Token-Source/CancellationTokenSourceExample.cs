using System;
using System.Threading;
using System.Threading.Tasks;

public class CancellationTokenDemoExample
{

    public void CancellationTokenDemo()
    {
        // 1. Creation and Token Retrieval:
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;

        // 2. Passing to Tasks:
        Task.Run(() => 
        {
            DoWork(token);
        });

        // Simulate some external condition or user input causing the cancellation
        Thread.Sleep(2000);  // Sleep for 2 seconds

        // 3. Requesting Cancellation:
        cts.Cancel();

        // Clean up
        cts.Dispose();
    }

    private void DoWork(CancellationToken token)
    {
        for (int i = 0; i < 10; i++)
        {
            // 4. Checking for Cancellation within a Task:
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancelled.");
                return;
            }
            
            // Simulate some piece of work
            Console.WriteLine($"Working... {i + 1}/10");
            Thread.Sleep(500);  // Sleep for 0.5 second
        }
    }

    // For demonstration: Cancellation after a delay
    public void CancelAfterDelayDemo()
    {
        CancellationTokenSource cts = new CancellationTokenSource();

        // Set to automatically cancel after 3 seconds
        cts.CancelAfter(TimeSpan.FromSeconds(3));

        try
        {
            // Wait for 5 seconds, if the token is not cancelled, this will complete
            // Otherwise, an exception will be thrown when the token is cancelled
            Task.Delay(TimeSpan.FromSeconds(5), cts.Token).Wait();
        }
        catch (AggregateException ae)
        {
            // Handle the exception caused by the cancellation
            Console.WriteLine("Task was cancelled.");
        }
        
        cts.Dispose();
    }

}
