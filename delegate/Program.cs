public class DelegateExample
{
    // Define the delegate
    public delegate int BinaryOperation(int a, int b);

    // Methods that match the delegate signature
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    // Using the delegate
    public void PerformOperations()
    {
        BinaryOperation operation = Add;
        Console.WriteLine($"Delegate (Add): {operation(5, 3)}"); // Outputs 8

        operation = Subtract;
        Console.WriteLine($"Delegate (Subtract): {operation(5, 3)}"); // Outputs 2
    }
}
class Program
{
    static void Main()
    {
        // New code for DelegateExample
        DelegateExample delegateExample = new DelegateExample();
        delegateExample.PerformOperations();
    }
}
