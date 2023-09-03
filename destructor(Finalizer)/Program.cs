using System;

public class ResourceHolder
{
    // Assume this class holds some unmanaged resources

    // Constructor
    public ResourceHolder()
    {
        Console.WriteLine("ResourceHolder created!");
    }

    // Destructor/Finalizer
    ~ResourceHolder()
    {
        Console.WriteLine("ResourceHolder destroyed!");
        // Here, you'd typically release any unmanaged resources.
    }
}

public class Program
{
    public static void Main()
    {
        CreateResourceHolder();
        GC.Collect(); // Forcing garbage collection for demonstration
        GC.WaitForPendingFinalizers(); // Wait for finalizers to finish
    }

    public static void CreateResourceHolder()
    {
        ResourceHolder resourceHolder = new ResourceHolder();
    }
}

