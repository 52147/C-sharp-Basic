using System;

public class MyClass
{
    public int Value;

    public MyClass(int value)
    {
        Value = value;
    }
}

public class Program
{
    public static void ModifyObject(MyClass obj)
    {
        obj.Value = 100; // This modification affects the original object.
    }

    public static void Main()
    {
        MyClass originalObject = new MyClass(10);

        Console.WriteLine($"Before method call: {originalObject.Value}");

        ModifyObject(originalObject);

        Console.WriteLine($"After method call: {originalObject.Value}");
    }
}

