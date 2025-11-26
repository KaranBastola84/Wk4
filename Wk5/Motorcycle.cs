namespace Wk4.Wk5
{
    // Derived class Motorcycle inherits from Vehicle
    public class Motorcycle : Vehicle
    {
        // Unique field for Motorcycle class
        public bool HasSidecar { get; set; }

        // Constructor to initialize motorcycle properties
        public Motorcycle(string brand, double speed, bool hasSidecar) : base(brand, speed)
        {
            HasSidecar = hasSidecar;
        }

        // Override DisplayInfo method to include unique field
        public override void DisplayInfo()
        {
            Console.WriteLine("=== Motorcycle Information ===");
            base.DisplayInfo(); // Call base class method to display brand and speed
            Console.WriteLine($"Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
        }
    }
}
