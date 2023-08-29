using System;
using System.Collections.Generic;

public class CollectionExamples
{
    public IEnumerable<string> GetIEnumerable()
    {
        IEnumerable<string> enumerable = new List<string>() { "apple", "banana", "cherry" };
        return enumerable;
    }

    public ICollection<string> GetICollection()
    {
        ICollection<string> collection = new List<string>();
        collection.Add("apple");
        collection.Add("banana");
        return collection;
    }

    public IList<string> GetIList()
    {
        IList<string> list = new List<string>();
        list.Add("apple");
        list.Add("banana");
        list.Insert(1, "cherry");
        return list;
    }

    public void DisplayElements<T>(IEnumerable<T> elements)
    {
        foreach(var element in elements)
        {
            Console.WriteLine(element);
        }
    }
}

public class Program
{
    public static void Main()
    {
        CollectionExamples examples = new CollectionExamples();

        Console.WriteLine("IEnumerable elements:");
        examples.DisplayElements(examples.GetIEnumerable());

        Console.WriteLine("\nICollection elements:");
        examples.DisplayElements(examples.GetICollection());

        Console.WriteLine("\nIList elements:");
        examples.DisplayElements(examples.GetIList());
    }
}

