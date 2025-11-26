namespace Wk4.Wk5
{
    // Derived class Car implementing abstract methods from AbstractVehicle
    public class AbstractCar : AbstractVehicle
    {
        // Implementation of abstract method StartEngine()
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started: Vroom! The car is ready to drive.");
        }

        // Implementation of abstract method StopEngine()
        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped: The car is now parked safely.");
        }
    }
}
