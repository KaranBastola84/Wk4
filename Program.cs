using Wk4.Wk4;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first student object
        Student student1 = new Student();

        // Assign values to instance fields of first student
        student1.name = "Alice";
        student1.age = 20;
        student1.major = "Computer Science";

        // Increment the static student count
        Student.studentCount++;

        // Create second student object
        Student student2 = new Student();

        // Assign different values to instance fields of second student
        student2.name = "Bob";
        student2.age = 22;
        student2.major = "Mathematics";

        // Increment the static student count
        Student.studentCount++;

        // Display field values of first student object
        Console.WriteLine("Student 1:");
        Console.WriteLine($"Name: {student1.name}, Age: {student1.age}, Major: {student1.major}");

        // Display field values of second student object
        Console.WriteLine("Student 2:");
        Console.WriteLine($"Name: {student2.name}, Age: {student2.age}, Major: {student2.major}");

        // Display the static field value (total student count)
        Console.WriteLine($"Total number of students: {Student.studentCount}");

        Console.WriteLine("\n--- Calculator Operations ---");

        // Create a Calculator object
        Calculator calculator = new Calculator();

        // Call PrintWelcome method
        calculator.PrintWelcome();

        // Call Add method and print the result
        int additionResult = calculator.Add(10, 5);
        Console.WriteLine($"Addition of 10 and 5: {additionResult}");

        // Call Multiply method with both parameters and print the result
        int multiplicationResult1 = calculator.Multiply(10, 5);
        Console.WriteLine($"Multiplication of 10 and 5: {multiplicationResult1}");

        // Call Multiply method with only one parameter (using default value for num2)
        int multiplicationResult2 = calculator.Multiply(10);
        Console.WriteLine($"Multiplication of 10 and 1 (default): {multiplicationResult2}");
    }
}