public class Sample
{
    // const 
    public const int ConstValue = 100;

    // readonly
    public readonly int ReadOnlyValue;

    // static 
    public static string StaticValue = "Static Field";

    public Sample(int readOnlyInput)
    {
        // Setting readonly value in constructor
        ReadOnlyValue = readOnlyInput;
    }

    // static method
    public static void DisplayStaticValue()
    {
        Console.WriteLine(StaticValue);
    }
}

public class Program
{
    static void Main()
    {
        Console.WriteLine(Sample.ConstValue); // Accessing const value

        var sampleObj = new Sample(200); // Passing a value to set readonly field
        Console.WriteLine(sampleObj.ReadOnlyValue); // Accessing readonly value
        
        Console.WriteLine(Sample.StaticValue); // Accessing static field
        Sample.DisplayStaticValue(); // Calling static method
    }
}
