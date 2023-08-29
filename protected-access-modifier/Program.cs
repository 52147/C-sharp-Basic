using System;

class MyBaseClass
{
    protected int protectedVariable = 0;

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method");
    }
}

class MyDerivedClass : MyBaseClass
{
    public void SomeMethod()
    {
        protectedVariable = 5; // Accessible because it's a derived class
        ProtectedMethod();     // Also accessible
    }
}

public class Program
{
    public static void Main()
    {
        MyDerivedClass derivedObject = new MyDerivedClass();
        derivedObject.SomeMethod(); // This will modify the protectedVariable and call the ProtectedMethod of the base class
    }
}
