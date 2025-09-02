using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\ShreyaSetty\\Documents\\favorites.txt";
        Console.WriteLine("Enter 5 favorite colors:");

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = 0; i < 5; i++)
            {
                writer.WriteLine(Console.ReadLine());
            }
        }

        Console.WriteLine("\nYour colors are:");
        foreach (var line in File.ReadLines(filePath))
        {
            Console.WriteLine(line);
        }
    }
}


