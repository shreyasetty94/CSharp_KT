using System;

class SmartMeterStatistics
{
    enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    static void Main()
    {
        int[] units = new int[7];
        Console.WriteLine("Enter units for each day (Mon-Sun):");

        for (int i = 0; i < 7; i++)
        {
            units[i] = int.Parse(Console.ReadLine());
        }

        int total = 0, maxUnits = units[0], maxDayIndex = 0;

        for (int i = 0; i < units.Length; i++)
        {
            total += units[i];
            if (units[i] > maxUnits)
            {
                maxUnits = units[i];
                maxDayIndex = i;
            }
        }

        double average = (double)total / units.Length;

        Console.WriteLine($"Total units: {total}");
        Console.WriteLine($"Average units/day: {average:F2}");
        Console.WriteLine($"Highest consumption: {Enum.GetName(typeof(Days), maxDayIndex)} ({maxUnits} units)");
    }
}
