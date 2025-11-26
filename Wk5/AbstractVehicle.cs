namespace Wk4.Wk5
{
    // Abstract class Vehicle demonstrating abstraction
    public abstract class AbstractVehicle
    {
        // Abstract method: Must be implemented by derived classes
        public abstract void StartEngine();

        // Abstract method: Must be implemented by derived classes
        public abstract void StopEngine();

        // Concrete method: Provides implementation in base class
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
