using System;

// Define a delegate type.
public delegate void OperationCompletedDelegate(int result);

public class Calculator
{
    // Method that takes a delegate as a parameter.
    public void Add(int num1, int num2, OperationCompletedDelegate callback)
    {
        int result = num1 + num2;
        
        // Invoke the delegate (call the method it's pointing to).
        callback(result);
    }
}

public class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        // Instantiate the delegate.
        OperationCompletedDelegate del = new OperationCompletedDelegate(OnOperationCompleted);

        // Call the Add method with the delegate as a parameter.
        calculator.Add(5, 3, del);
    }

    // This method matches the signature of the OperationCompletedDelegate.
    static void OnOperationCompleted(int result)
    {
        Console.WriteLine($"Operation completed. Result: {result}");
    }
}

