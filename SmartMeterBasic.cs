using System;

class SmartMeterBasic
{
    static void Main()
    {
        Console.Write("Enter units consumed: ");
        int units = int.Parse(Console.ReadLine());
        int bill = 0;

        if (units <= 100)
        {
            bill = units * 5;
        }
        else if (units <= 200)
        {
            bill = (100 * 5) + (units - 100) * 7;
        }
        else
        {
            bill = (100 * 5) + (100 * 7) + (units - 200) * 10;
        }

        Console.WriteLine("Total electricity bill: Rs." + bill);
    }
}
