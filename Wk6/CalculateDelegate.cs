namespace Wk4.Wk6
{
    // Delegate that accepts two integers and returns an integer
    public delegate int Calculate(int num1, int num2);

    // Class containing methods for Calculate delegate
    public class Calculator
    {
        // Method to add two numbers
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Method to subtract two numbers
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
