using System;
public class AccessExample
{
    public int publicNumber = 10;
    private int privateNumber = 20;
    internal int internalNumber = 30;
    public void ShowNumbers()
    {
        Console.WriteLine("Public Number: " + publicNumber);
        Console.WriteLine("Private Number: " + privateNumber);
        Console.WriteLine("Internal Number: " + internalNumber);
    }
}
class Program_AccessSimple
{
    static void Main()
    {
        AccessExample obj = new AccessExample();
        Console.WriteLine("From Main Method:");
        Console.WriteLine(obj.publicNumber);
        Console.WriteLine(obj.internalNumber);
        Console.WriteLine("\nFrom Inside Class Method:");
        obj.ShowNumbers();
    }
}
