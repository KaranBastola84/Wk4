namespace Wk4.Wk5
{
    // ElectronicsStore class to manage electronic devices
    public class ElectronicsStore
    {
        // Private list to maintain electronic devices
        private List<ElectronicDevice> devices;

        // Constructor to initialize the device list
        public ElectronicsStore()
        {
            devices = new List<ElectronicDevice>();
        }

        // Method to add a device to the store
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"Device added to store: {device.Brand}");
        }

        // Method to remove a device from the store
        public void RemoveDevice(ElectronicDevice device)
        {
            if (devices.Remove(device))
            {
                Console.WriteLine($"Device removed from store: {device.Brand}");
            }
            else
            {
                Console.WriteLine("Device not found in store.");
            }
        }

        // Method to display information of all devices in the store
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("    ELECTRONICS STORE - INVENTORY");
            Console.WriteLine("========================================");

            if (devices.Count == 0)
            {
                Console.WriteLine("No devices in store.");
                return;
            }

            for (int i = 0; i < devices.Count; i++)
            {
                Console.WriteLine($"\n--- Device #{i + 1} ---");

                // Call ShowInfo() for each device (polymorphism)
                devices[i].ShowInfo();

                // Downcast to access child-specific methods
                if (devices[i] is Laptop laptop)
                {
                    Console.WriteLine("\nDemonstrating Laptop-specific feature:");
                    laptop.TurnOnBattery();
                }
                else if (devices[i] is Smartphone smartphone)
                {
                    Console.WriteLine("\nDemonstrating Smartphone-specific feature:");
                    smartphone.EnableCamera();
                }

                Console.WriteLine(); // Empty line for readability
            }

            Console.WriteLine("========================================");
            Console.WriteLine($"Total devices in store: {devices.Count}");
            Console.WriteLine("========================================");
        }
    }
}
