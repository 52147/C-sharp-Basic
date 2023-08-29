using System;

public class Person
{
    // Field
    private string _name; // This is a field. Note the underscore naming convention for private fields.

    // Property
    public string Name 
    {
        get 
        {
            return _name; 
        }
        set 
        {
            if (!string.IsNullOrEmpty(value))  // Ensure the name is not empty or null
            {
                _name = value; 
            }
            else
            {
                Console.WriteLine("Name cannot be empty!");
            }
        }
    }

    // Another Field
    private int _age;

    // Another Property
    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 0)  // Ensure the age is not negative
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Age cannot be negative!");
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        Person person = new Person();
        person.Name = "John"; // Sets the value using the property
        person.Age = 25;      // Sets the value using the property

        Console.WriteLine($"Name: {person.Name}"); // Accesses the value using the property
        Console.WriteLine($"Age: {person.Age}");   // Accesses the value using the property

        // Attempting to set invalid data
        person.Name = "";
        person.Age = -5;
    }
}
