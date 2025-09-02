using System;
using System.Collections.Generic;

enum MeterStatus { Active, Inactive, Fault }

struct Reading
{
    public DateTime Date;
    public int Units;
    public Reading(DateTime date, int units)
    {
        Date = date;
        Units = units;
    }
}

abstract class Notifier
{
    public abstract void SendMessage(string msg);
}

class SmsNotifier : Notifier
{
    public override void SendMessage(string msg) => Console.WriteLine("SMS: " + msg);
}

class EmailNotifier : Notifier
{
    public override void SendMessage(string msg) => Console.WriteLine("Email: " + msg);
}

static class Tariff
{
    public static int RatePerUnit = 5;
}

sealed class BillCalculator
{
    public int Calculate(List<Reading> readings)
    {
        int total = 0;
        foreach (var r in readings) total += r.Units;
        return total * Tariff.RatePerUnit;
    }
}

partial class Customer
{
    public string Name { get; set; }
    public string? Email { get; set; }
}
partial class Customer
{
    public string Phone { get; set; }
}

class Meter
{
    public int MeterId { get; set; }
    public MeterStatus Status { get; set; }

    public class ReadingHistory
    {
        public List<Reading> Readings { get; } = new List<Reading>();
        public void Add(Reading r) => Readings.Add(r);
    }

    public ReadingHistory History { get; } = new ReadingHistory();
    public event Action<string> OnNewReading;

    public void AddReading(Reading r)
    {
        History.Add(r);
        OnNewReading?.Invoke($"{r.Units} units recorded on {r.Date.ToShortDateString()}");
    }
}

class BillingSystem
{
    static void Main()
    {
        var customer = new Customer { Name = "Alice", Phone = "9999999999", Email = null };
        string contact = customer.Email ?? customer.Phone;
        Console.WriteLine($"Contact for {customer.Name}: {contact}");

        var meter = new Meter { MeterId = 101, Status = MeterStatus.Active };
        Notifier notifier = customer.Email != null ? new EmailNotifier() : new SmsNotifier();
        meter.OnNewReading += notifier.SendMessage;

        meter.AddReading(new Reading(DateTime.Now, 50));
        meter.AddReading(new Reading(DateTime.Now.AddDays(1), 70));

        var billCalc = new BillCalculator();
        int bill = billCalc.Calculate(meter.History.Readings);
        Console.WriteLine($"Total Bill: ₹{bill}");
    }
}
