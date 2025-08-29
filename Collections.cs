using System;
using System.Collections.Generic;

class Collections
{
    static void Main()
    {
        List<List<int>> weeklyReadings = new List<List<int>>()
        {
            new List<int>{10,20,30}, 
            new List<int>{15,25,35}, 
            new List<int>{12,22,32},
            new List<int>{14,24,34}, 
            new List<int>{16,26,36},
            new List<int>{18,28,38}, 
            new List<int>{20,30,40} 
        };

        Console.WriteLine("Night reading of Day 3: " + weeklyReadings[2][2]);

        var nestedDict = new Dictionary<string, Dictionary<string, List<int>>>
        {
            { "Area1", new Dictionary<string, List<int>> {
                { "House101", new List<int>{100,110,120,130,140,150,160} }
            }},
            { "Area2", new Dictionary<string, List<int>> {
                { "House201", new List<int>{200,210,220,230,240,250,260} }
            }}
        };

        Console.WriteLine("Readings of House101:");
        foreach (var r in nestedDict["Area1"]["House101"])
            Console.Write(r + " ");
        Console.WriteLine();

        var areaMeters = new Dictionary<string, List<string>>
        {
            { "Area1", new List<string>{ "MTR101", "MTR102" } },
            { "Area2", new List<string>{ "MTR201", "MTR202" } }
        };

        Console.WriteLine("Meters in Area2: " + string.Join(", ", areaMeters["Area2"]));

        var complaints = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string>{{"House","101"},{"Issue","Power Cut"},{"Date","2025-08-20"}},
            new Dictionary<string, string>{{"House","202"},{"Issue","Meter Fault"},{"Date","2025-08-21"}}
        };

        Console.WriteLine("Complaints:");
        foreach (var comp in complaints)
            Console.WriteLine($"House: {comp["House"]}, Issue: {comp["Issue"]}, Date: {comp["Date"]}");
    }
}
