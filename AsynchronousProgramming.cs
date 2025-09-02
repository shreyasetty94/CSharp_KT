using System;
using System.Threading.Tasks;

class AsynchronousProgramming
{
    static async Task Main()
    {
        Console.WriteLine("Starting file download simulation...");
        await DownloadFileAsync();
    }

    static async Task DownloadFileAsync()
    {
        await Task.Delay(5000);
        Console.WriteLine("Download complete!");
    }
}
