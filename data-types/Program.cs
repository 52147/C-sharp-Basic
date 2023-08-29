using System;

class DataTypesExample
{
    // Value Types:
    
    // Primitive Types:
    byte aByte = 255;               // 8-bit unsigned integer
    sbyte aSByte = -128;            // 8-bit signed integer
    int anInt = 12345;              // 32-bit signed integer
    uint aUInt = 12345;             // 32-bit unsigned integer
    short aShort = -32768;          // 16-bit signed integer
    ushort aUShort = 65535;         // 16-bit unsigned integer
    long aLong = 1234567890123456;  // 64-bit signed integer
    ulong aULong = 1234567890123456; // 64-bit unsigned integer
    float aFloat = 3.14f;           // 32-bit floating-point number
    double aDouble = 3.141592653589793; // 64-bit floating-point number
    decimal aDecimal = 3.141592653589793m; // 128-bit precise decimal values
    bool aBool = true;              // Boolean value
    char aChar = 'A';               // Single 16-bit Unicode character

    // Struct:
    DateTime dateTime = DateTime.Now; // A built-in struct representing date and time

    // Enumeration:
    Days day = Days.Wednesday;      // Using the Days enum defined below
    
    // Reference Types:

    // Class:
    Person aPerson = new Person() { Name = "Alice", Age = 30 }; // Using the Person class defined below

    // String:
    string aString = "Hello, World!";

    // Array:
    int[] intArray = new int[] { 1, 2, 3, 4, 5 };
    
    public void DisplayValues()
    {
        Console.WriteLine($"Byte: {aByte}");
        Console.WriteLine($"Short: {aShort}");
        Console.WriteLine($"Int: {anInt}");
        Console.WriteLine($"Long: {aLong}");
        Console.WriteLine($"Float: {aFloat}");
        Console.WriteLine($"Double: {aDouble}");
        Console.WriteLine($"Decimal: {aDecimal}");
        Console.WriteLine($"Bool: {aBool}");
        Console.WriteLine($"Char: {aChar}");
        Console.WriteLine($"DateTime: {dateTime}");
        Console.WriteLine($"Enum: {day}");
        Console.WriteLine($"Person: {aPerson.Name}, Age: {aPerson.Age}");
        Console.WriteLine($"String: {aString}");
        Console.WriteLine($"Array[2]: {intArray[2]}"); // Displays the third element in the array
    }
}

enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        DataTypesExample example = new DataTypesExample();
        example.DisplayValues();
    }
}
