using System;
using System.Threading;

public class Clock
{
    // 1. Define a delegate type.
    public delegate void TickHandler(object sender, EventArgs args);

    // 2. Define an event of the delegate type.
    public event TickHandler Tick;

    public void Start()
    {
        while (true)
        {
            Thread.Sleep(1000); // Simulate the ticking of a clock every second.
            OnTick(); // Raise the tick event.
        }
    }

    // Method to raise the Tick event.
    protected virtual void OnTick()
    {
        // If there are any subscribers to the Tick event, notify them.
        if (Tick != null)
        {
            Tick(this, EventArgs.Empty);
        }
    }
}

public class Program
{
    static void Main()
    {
        Clock clock = new Clock();

        // 3. Subscribe to the Tick event.
        clock.Tick += Clock_Tick;

        clock.Start();
    }

    // Event handler.
    static void Clock_Tick(object sender, EventArgs e)
    {
        Console.WriteLine("Clock ticked!");
    }
}
