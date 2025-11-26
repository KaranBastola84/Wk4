namespace Wk4.Wk5
{
    // Base class Vehicle
    public class Vehicle
    {
        // Property: Brand of the vehicle
        public string Brand { get; set; }

        // Property: Speed of the vehicle
        public double Speed { get; set; }

        // Constructor to initialize brand and speed
        public Vehicle(string brand, double speed)
        {
            Brand = brand;
            Speed = speed;
        }

        // Method: Start the vehicle
        public void Start()
        {
            Console.WriteLine($"{Brand} is starting...");
        }

        // Method: Stop the vehicle
        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping...");
        }

        // Virtual method: Display vehicle information (can be overridden)
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
        }
    }
}
