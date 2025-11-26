namespace Wk4.Wk5
{
    // Printer class demonstrating method overloading (compile-time polymorphism)
    public class Printer
    {
        // Overloaded method: Print a string message
        public void Print(string message)
        {
            Console.WriteLine($"Printing message: {message}");
        }

        // Overloaded method: Print an integer number
        public void Print(int number)
        {
            Console.WriteLine($"Printing number: {number}");
        }

        // Overloaded method: Print a string message multiple times
        public void Print(string message, int count)
        {
            Console.WriteLine($"Printing message '{message}' {count} times:");
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"  {i}. {message}");
            }
        }
    }
}
