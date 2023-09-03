using System;

public struct MyStruct
{
    public int Value;

    public MyStruct(int value)
    {
        Value = value;
    }
}

public class Program
{
    public static void ModifyStruct(MyStruct s)
    {
        s.Value = 100; // This modification affects only the copy of the struct passed into this method.
    }

    public static void Main()
    {
        MyStruct originalStruct = new MyStruct(10);

        Console.WriteLine($"Before method call: {originalStruct.Value}");

        ModifyStruct(originalStruct);

        Console.WriteLine($"After method call: {originalStruct.Value}");
    }
}

