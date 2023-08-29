using System;

public class MyClass
{
    private int _id;

    public MyClass(int id)
    {
        _id = id;
        Console.WriteLine($"Object with ID {_id} is created.");
    }

    ~MyClass() // Destructor
    {
        Console.WriteLine($"Object with ID {_id} is being finalized.");
    }
}

public class Program
{
    public static void Main()
    {
        // Creating objects
        MyClass obj1 = new MyClass(1);
        MyClass obj2 = new MyClass(2);
        
        // Setting references to null
        obj1 = null;
        obj2 = null;

        // Requesting the GC to run (usually it's not manually called)
        GC.Collect();


        Console.WriteLine("Garbage Collection completed.");
    }
}
