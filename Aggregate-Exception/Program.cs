using System;
using System.Linq;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        try
        {
            Task[] tasks = new Task[2];

            tasks[0] = Task.Factory.StartNew(() => { throw new InvalidOperationException("Task 0 faulted."); });
            tasks[1] = Task.Factory.StartNew(() => { throw new NullReferenceException("Task 1 faulted."); });

            Task.WhenAll(tasks).Wait();
        }
        catch (AggregateException ae)
        {
            // Flatten the AggregateException to handle inner exceptions individually
            ae = ae.Flatten();

            foreach (var ex in ae.InnerExceptions)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
