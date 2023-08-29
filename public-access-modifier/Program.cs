public class MyClass
{
    public int publicVariable = 0;
    
    public void PublicMethod()
    {
        Console.WriteLine("Public method");
    }
}
public class Program
{
    public static void Main()
    {
        MyClass obj = new MyClass();  // Creating an instance of MyClass

        Console.WriteLine(obj.publicVariable);  // Accessing and printing the public field

        obj.PublicMethod();  // Calling the public method
    }
}