using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Name} - ${Price}";
    }
}

public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 800 },
            new Product { Name = "Mouse", Price = 20 },
            new Product { Name = "Monitor", Price = 150 },
            new Product { Name = "Keyboard", Price = 50 }
        };

        // Using a delegate to perform custom sorting based on the product's price.
        products.Sort(delegate(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        });

        // Display sorted products
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}

