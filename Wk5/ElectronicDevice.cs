namespace Wk4.Wk5
{
    // Abstract class ElectronicDevice demonstrating abstraction and encapsulation
    public abstract class ElectronicDevice
    {
        // Private fields (encapsulation)
        private string brand;
        private double price;

        // Public property: Brand (encapsulation - controlled access to private field)
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        // Public property: Price (encapsulation - controlled access to private field)
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Error: Price cannot be negative.");
                }
            }
        }

        // Constructor to initialize Brand and Price
        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        // Abstract method: Must be implemented by derived classes
        public abstract void ShowInfo();
    }
}
