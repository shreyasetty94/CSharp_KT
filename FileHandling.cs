using System;
using System.IO;
using System.Threading.Tasks;

class FileHandling
{
    static async Task Main()
    {
        Console.WriteLine("Enter 5 favorite colors:");
        string filePath = "C:\\Users\\ShreyaSetty\\Documents\\favorites.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = 0; i < 5; i++)
            {
                string color = Console.ReadLine();
                writer.WriteLine(color);
            }
        }

        Console.WriteLine("\nColors saved! Now reading from file:\n");
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        Console.WriteLine("\nStarting file download simulation...");
        await DownloadFileAsync();
    }

    static async Task DownloadFileAsync()
    {
        await Task.Delay(5000); 
        Console.WriteLine("Download complete!");
    }
}
