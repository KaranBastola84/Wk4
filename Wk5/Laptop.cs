namespace Wk4.Wk5
{
    // Derived class Laptop inheriting from ElectronicDevice
    public class Laptop : ElectronicDevice
    {
        // Constructor to initialize laptop with brand and price
        public Laptop(string brand, double price) : base(brand, price)
        {
        }

        // Override abstract method ShowInfo() to display laptop details
        public override void ShowInfo()
        {
            Console.WriteLine("=== Laptop Information ===");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine("Type: Laptop Computer");
        }

        // Extra method specific to Laptop class
        public void TurnOnBattery()
        {
            Console.WriteLine($"{Brand} Laptop: Battery powered on. Laptop is running on battery mode.");
        }
    }
}
