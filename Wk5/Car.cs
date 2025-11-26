namespace Wk4.Wk5
{
    // Derived class Car inherits from Vehicle
    public class Car : Vehicle
    {
        // Unique field for Car class
        public int Seats { get; set; }

        // Constructor to initialize car properties
        public Car(string brand, double speed, int seats) : base(brand, speed)
        {
            Seats = seats;
        }

        // Override DisplayInfo method to include unique field
        public override void DisplayInfo()
        {
            Console.WriteLine("=== Car Information ===");
            base.DisplayInfo(); // Call base class method to display brand and speed
            Console.WriteLine($"Number of Seats: {Seats}");
        }
    }
}
