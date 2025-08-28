using System;

// Base class
class SmartMeter
{
    public int MeterId { get; set; }
    public string CustomerName { get; set; }

    public SmartMeter(int meterId, string name)
    {
        MeterId = meterId;
        CustomerName = name;
    }

    public virtual void ShowDetails()
    {
        Console.WriteLine($"Meter -> ID: {MeterId}, Name: {CustomerName}");
    }
}

// Derived class: ResidentialMeter
class ResidentialMeter : SmartMeter
{
    public string HouseType { get; set; }

    public ResidentialMeter(int meterId, string name, string houseType)
        : base(meterId, name)
    {
        HouseType = houseType;
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Residential Meter -> ID: {MeterId}, Name: {CustomerName}, HouseType: {HouseType}");
    }
}

// Derived class: CommercialMeter
class CommercialMeter : SmartMeter
{
    public string BusinessType { get; set; }

    public CommercialMeter(int meterId, string name, string businessType)
        : base(meterId, name)
    {
        BusinessType = businessType;
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Commercial Meter -> ID: {MeterId}, Name: {CustomerName}, BusinessType: {BusinessType}");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        ResidentialMeter rMeter = new ResidentialMeter(201, "Alice", "Apartment");
        CommercialMeter cMeter = new CommercialMeter(301, "Bob", "Shop");

        rMeter.ShowDetails();
        cMeter.ShowDetails();
    }
}
