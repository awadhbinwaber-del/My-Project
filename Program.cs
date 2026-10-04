using System;

public class Vehicle
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public virtual void Start()
    {
        Console.WriteLine($"{Brand} vehicle (Year: {Year}) is starting.");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string brand, int year, int numberOfDoors) : base(brand, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void Start()
    {
        Console.WriteLine($"Car -> {Brand} ({Year}) with {NumberOfDoors} doors is starting with a roar!");
    }
}

public class Bus : Vehicle
{
    public int Capacity { get; set; }

    public Bus(string brand, int year, int capacity) : base(brand, year)
    {
        Capacity = capacity;
    }

    public override void Start()
    {
        Console.WriteLine($"Bus -> {Brand} ({Year}) with capacity of {Capacity} passengers is starting.");
    }
}

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string brand, int year, bool hasSidecar) : base(brand, year)
    {
        HasSidecar = hasSidecar;
    }

    public override void Start()
    {
        string sidecarStatus = HasSidecar ? "with a sidecar" : "without a sidecar";
        Console.WriteLine($"Motorcycle -> {Brand} ({Year}) {sidecarStatus} is starting.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", 2023, 4);
        Bus myBus = new Bus("Mercedes", 2021, 50);
        Motorcycle myMoto = new Motorcycle("Harley-Davidson", 2022, false);

        myCar.Start();
        myBus.Start();
        myMoto.Start();
    }
}
