using System;

public class Clock
{
    // Delegate declaration
    public delegate void TimeChangedDelegate(int hour, int min, int sec);

    // Event declaration
    public event TimeChangedDelegate TimeChanged;

    public void RunClock()
    {
        for (int i = 0; i < 5; i++)
        {
            System.Threading.Thread.Sleep(1000); // Wait for 1 second
            OnTimeChanged(i, i + 10, i + 20); // Just simulating some time change
        }
    }

    protected virtual void OnTimeChanged(int hour, int min, int sec)
    {
        TimeChanged?.Invoke(hour, min, sec);
    }
}

public class DisplayClock
{
    public void Subscribe(Clock clock)
    {
        clock.TimeChanged += ShowTime;
    }

    public void ShowTime(int hour, int min, int sec)
    {
        Console.WriteLine($"Current time: {hour}:{min}:{sec}");
    }
}

public class Program
{
    public static void Main()
    {
        Clock clock = new Clock();
        DisplayClock display = new DisplayClock();

        display.Subscribe(clock); // Subscribing to the event

        clock.RunClock();
    }
}
