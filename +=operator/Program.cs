using System;

namespace DemoApp
{
    class Program
    {
        // Define an event
        public event EventHandler MyEvent;

        static void Main(string[] args)
        {   
            // 1. Accumulation:
            // Demonstrate += with integers
            int x = 5;
            x += 3;  // Equivalent to: x = x + 3; 
            Console.WriteLine(x);  // Outputs: 8

            // 2. Event Subscription:
            // Demonstrate += with events
            Program p = new Program();
            p.RegisterEvent();
            
            // Trigger the event
            p.MyEvent?.Invoke(p, EventArgs.Empty);
        }

        public void RegisterEvent()
        {
            MyEvent += MyEventHandler;  // Subscribing MyEventHandler to MyEvent
        }

        private void MyEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Event was triggered!");
        }
    }
}


