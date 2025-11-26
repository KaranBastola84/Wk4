namespace Wk4.Wk5
{
    // Derived class Bike implementing abstract methods from AbstractVehicle
    public class Bike : AbstractVehicle
    {
        // Implementation of abstract method StartEngine()
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started: Vroooom! The bike is revving up.");
        }

        // Implementation of abstract method StopEngine()
        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped: The bike is now at rest.");
        }
    }
}
