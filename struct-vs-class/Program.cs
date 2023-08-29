// Define a struct
public struct PointStruct
{
    public int X;
    public int Y;

    public PointStruct(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }
}

// Define a class
public class PointClass
{
    public int X;
    public int Y;

    public PointClass() { }  // Default constructor

    public PointClass(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }
}

class Program
{
    static void Main()
    {
        PointStruct ps1 = new PointStruct(1, 1);
        PointStruct ps2 = ps1;
        ps2.Move(1, 1);
        Console.WriteLine($"ps1: {ps1.X}, {ps1.Y}"); // Outputs "ps1: 1, 1"
        Console.WriteLine($"ps2: {ps2.X}, {ps2.Y}"); // Outputs "ps2: 2, 2"

        PointClass pc1 = new PointClass(1, 1);
        PointClass pc2 = pc1;
        pc2.Move(1, 1);
        Console.WriteLine($"pc1: {pc1.X}, {pc1.Y}"); // Outputs "pc1: 2, 2"
        Console.WriteLine($"pc2: {pc2.X}, {pc2.Y}"); // Outputs "pc2: 2, 2"
    }
}
