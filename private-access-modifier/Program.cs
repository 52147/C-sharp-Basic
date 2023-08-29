using System;

public class MyClass
{
    private int privateVariable = 0;

    private void PrivateMethod()
    {
        Console.WriteLine("Private method");
    }

    // A public method to access the private field and method
    public void Display()
    {
        Console.WriteLine("Value of privateVariable: " + privateVariable);
        PrivateMethod();
    }
}

public class Program
{
    public static void Main()
    {
        MyClass obj = new MyClass();
        obj.Display(); // This will access the private members of MyClass via the Display method
    }
}

