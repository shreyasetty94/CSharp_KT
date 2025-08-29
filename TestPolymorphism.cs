using System;

// Abstract class
abstract class MeterReading
{
    public int Units { get; set; }
    public MeterReading(int units)
    {
        Units = units;
    }
    public abstract int CalculateBill();
}

// ResidentialReading → ₹5/unit
class ResidentialReading : MeterReading
{
    public ResidentialReading(int units) : base(units) { }
    public override int CalculateBill()
    {
        return Units * 5;
    }
}

// CommercialReading → ₹8/unit
class CommercialReading : MeterReading
{
    public CommercialReading(int units) : base(units) { }
    public override int CalculateBill()
    {
        return Units * 8;
    }
}

class TestPolymorphism
{
    static void Main()
    {
        MeterReading res = new ResidentialReading(100);
        MeterReading com = new CommercialReading(100);

        Console.WriteLine($"Residential Bill = {res.CalculateBill()}");
        Console.WriteLine($"Commercial Bill = {com.CalculateBill()}");
    }
}
