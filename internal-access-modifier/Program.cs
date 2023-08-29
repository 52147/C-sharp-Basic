internal class MyInternalClass
{
    internal int internalVariable = 0;
    
    internal void InternalMethod()
    {
        Console.WriteLine("Internal method");
    }
}
public class Program
{
    public static void Main()
    {
        MyInternalClass obj = new MyInternalClass();  // Creating an instance of MyInternalClass

        Console.WriteLine(obj.internalVariable);  // Accessing and printing the internal field

        obj.InternalMethod();  // Calling the internal method
    }
}
