using System;

public class MyBaseClass
{
    protected internal int protectedInternalVariable = 0;

    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("Protected Internal method");
    }
}

class MyDerivedClass : MyBaseClass
{
    public void SomeMethod()
    {
        protectedInternalVariable = 5; // Accessible because it's a derived class
        ProtectedInternalMethod();     // Also accessible
    }
}

public class Program
{
    public static void Main()
    {
        MyDerivedClass derivedObject = new MyDerivedClass();
        Console.WriteLine(derivedObject.protectedInternalVariable);
        derivedObject.SomeMethod(); // This will modify the protectedInternalVariable and call the ProtectedInternalMethod
        Console.WriteLine(derivedObject.protectedInternalVariable);
    }
}
