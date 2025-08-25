using System;

class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public int UnitsConsumed { get; set; }

    public Customer(int id, string name, int units)
    {
        CustomerID = id;
        Name = name;
        UnitsConsumed = units;
    }

    public void ShowBill()
    {
        int bill = UnitsConsumed * 5;
        Console.WriteLine($"Customer: {Name} (ID: {CustomerID})");
        Console.WriteLine($"Units Consumed: {UnitsConsumed}");
        Console.WriteLine($"Total Bill: ${bill}");
    }
}

class SmartMeterCustomer
{
    static void Main()
    {
        Console.Write("Enter Customer ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Units Consumed: ");
        int units = int.Parse(Console.ReadLine());

        Customer customer = new Customer(id, name, units);
        customer.ShowBill();
    }
}
