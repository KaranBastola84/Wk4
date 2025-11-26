namespace Wk4.Wk5
{
    // Derived class Smartphone inheriting from ElectronicDevice
    public class Smartphone : ElectronicDevice
    {
        // Constructor to initialize smartphone with brand and price
        public Smartphone(string brand, double price) : base(brand, price)
        {
        }

        // Override abstract method ShowInfo() to display smartphone details
        public override void ShowInfo()
        {
            Console.WriteLine("=== Smartphone Information ===");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine("Type: Smartphone");
        }

        // Extra method specific to Smartphone class
        public void EnableCamera()
        {
            Console.WriteLine($"{Brand} Smartphone: Camera enabled. Ready to take photos.");
        }
    }
}
