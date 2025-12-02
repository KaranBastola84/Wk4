using Wk4.Wk4;
using Wk4.Wk5;
using Wk4.Wk6;
using System;

class Program
{
    static void Main(string[] args)
    {
        // // Create first student object
        // Student student1 = new Student();

        // // Assign values to instance fields of first student
        // student1.name = "Alice";
        // student1.age = 20;
        // student1.major = "Computer Science";

        // // Increment the static student count
        // Student.studentCount++;

        // // Create second student object
        // Student student2 = new Student();

        // // Assign different values to instance fields of second student
        // student2.name = "Bob";
        // student2.age = 22;
        // student2.major = "Mathematics";

        // // Increment the static student count
        // Student.studentCount++;

        // // Display field values of first student object
        // Console.WriteLine("Student 1:");
        // Console.WriteLine($"Name: {student1.name}, Age: {student1.age}, Major: {student1.major}");

        // // Display field values of second student object
        // Console.WriteLine("Student 2:");
        // Console.WriteLine($"Name: {student2.name}, Age: {student2.age}, Major: {student2.major}");

        // // Display the static field value (total student count)
        // Console.WriteLine($"Total number of students: {Student.studentCount}");

        // Console.WriteLine("\n--- Calculator Operations ---");

        // // Create a Calculator object
        // Calculator calculator = new Calculator();

        // // Call PrintWelcome method
        // calculator.PrintWelcome();

        // // Call Add method and print the result
        // int additionResult = calculator.Add(10, 5);
        // Console.WriteLine($"Addition of 10 and 5: {additionResult}");

        // // Call Multiply method with both parameters and print the result
        // int multiplicationResult1 = calculator.Multiply(10, 5);
        // Console.WriteLine($"Multiplication of 10 and 5: {multiplicationResult1}");

        // // Call Multiply method with only one parameter (using default value for num2)
        // int multiplicationResult2 = calculator.Multiply(10);
        // Console.WriteLine($"Multiplication of 10 and 1 (default): {multiplicationResult2}");

        // Console.WriteLine("\n--- Parameter Demo Operations ---");

        // // Create a ParameterDemo object
        // ParameterDemo paramDemo = new ParameterDemo();

        // // Demonstrate ref parameter - Increase method
        // int number = 20;
        // Console.WriteLine($"Original number: {number}");
        // paramDemo.Increase(ref number);
        // Console.WriteLine($"After Increase (ref parameter): {number}");

        // // Demonstrate out parameter - GetFullName method
        // string fullName;
        // paramDemo.GetFullName(out fullName);
        // Console.WriteLine($"Full Name (out parameter): {fullName}");

        // // Demonstrate params parameter - SumAll method with different number of arguments
        // int sum1 = paramDemo.SumAll(1, 2, 3, 4, 5);
        // Console.WriteLine($"Sum of 1, 2, 3, 4, 5: {sum1}");

        // int sum2 = paramDemo.SumAll(10, 20, 30);
        // Console.WriteLine($"Sum of 10, 20, 30: {sum2}");

        // int sum3 = paramDemo.SumAll(100);
        // Console.WriteLine($"Sum of 100: {sum3}");

        // Console.WriteLine("\n--- Player Constructor Demo ---");

        // // Create first player object using default constructor
        // Console.WriteLine("Creating Player 1 with default constructor:");
        // Player player1 = new Player();

        // // Manually assign values to player1 fields
        // player1.playerName = "Guest";
        // player1.level = 1;
        // player1.health = 100;

        // // Display field values of player1 object
        // Console.WriteLine($"Player 1 - Name: {player1.playerName}, Level: {player1.level}, Health: {player1.health}");

        // // Create second player object using parameterized constructor
        // Console.WriteLine("\nCreating Player 2 with parameterized constructor:");
        // Player player2 = new Player("WarriorKing", 25, 500);

        // // Display field values of player2 object
        // Console.WriteLine($"Player 2 - Name: {player2.playerName}, Level: {player2.level}, Health: {player2.health}");

        // Console.WriteLine("\n--- Enum DayType Demo ---");

        // // Ask user to input the day
        // Console.Write("Enter a day (e.g., Sunday, Monday, etc.): ");
        // string? userInput = Console.ReadLine();

        // // Determine the day type based on user input
        // if (userInput != null)
        // {
        //     string day = userInput.Trim();
        //     DayType dayType;

        //     // Check if the day is Friday or Saturday (Weekend)
        //     if (day.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
        //         day.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
        //     {
        //         dayType = DayType.Weekend;
        //     }
        //     else
        //     {
        //         dayType = DayType.Weekday;
        //     }

        //     // Print the day type
        //     Console.WriteLine($"It is: {dayType}");
        // }

        // Console.WriteLine("\n--- Record Book Demo ---");

        // // Create first book object with initial values
        // Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 15.99);
        // Console.WriteLine($"Book 1 - Title: {book1.title}, Author: {book1.author}, Price: ${book1.price}");

        // // Create second book object using 'with' expression to change title and price
        // Book book2 = book1 with { title = "1984", price = 12.99 };

        // // Print the value of first object (unchanged)
        // Console.WriteLine($"\nBook 1 (original) - Title: {book1.title}, Author: {book1.author}, Price: ${book1.price}");

        // // Deconstruct the second object into three variables
        // var (title, author, price) = book2;
        // Console.WriteLine($"\nBook 2 (deconstructed variables):");
        // Console.WriteLine($"Title: {title}");
        // Console.WriteLine($"Author: {author}");
        // Console.WriteLine($"Price: ${price}");

        // Console.WriteLine("\n--- Debugging Exercise: Percentage Calculation ---");

        // // Ask user to input marks
        // Console.Write("Enter marks obtained: ");
        // string? marksInput = Console.ReadLine();

        // // Ask user to input total marks
        // Console.Write("Enter total marks: ");
        // string? totalInput = Console.ReadLine();

        // // Use TryParse to safely convert string inputs to integers
        // int marks = 0;
        // int total = 0;
        // bool isMarksValid = int.TryParse(marksInput, out marks);
        // bool isTotalValid = int.TryParse(totalInput, out total);

        // // Check if both inputs are valid
        // if (isMarksValid && isTotalValid && total != 0)
        // {
        //     // SET BREAKPOINT HERE - Before calculation (Line with this comment)
        //     // This is where you should set the first breakpoint to observe variable values

        //     // Calculate percentage (BUGGY CODE - integer division issue)
        //     double percentage = marks / total * 100;

        //     // SET BREAKPOINT HERE - After calculation (Line with this comment)
        //     // This is where you should set the second breakpoint to observe the result

        //     // Print the percentage
        //     Console.WriteLine($"Percentage: {percentage}%");

        //     // DEBUGGING ANALYSIS:
        //     // WHY IS THE OUTPUT INCORRECT?
        //     // - When dividing two integers (marks / total), C# performs integer division
        //     // - Integer division truncates the decimal part (e.g., 85/100 = 0, not 0.85)
        //     // - Then multiplying by 100 gives: 0 * 100 = 0
        //     // - This results in incorrect percentage (0% instead of 85%)

        //     // HOW TO CORRECT THE PROGRAM?
        //     // Solution 1: Cast one operand to double before division
        //     // double percentage = (double)marks / total * 100;

        //     // Solution 2: Cast both operands to double
        //     // double percentage = (double)marks / (double)total * 100;

        //     // Solution 3: Multiply first, then divide (but may cause overflow for large numbers)
        //     // double percentage = (double)(marks * 100) / total;

        //     Console.WriteLine("\n--- CORRECTED VERSION ---");
        //     double correctPercentage = (double)marks / total * 100;
        //     Console.WriteLine($"Correct Percentage: {correctPercentage}%");
        // }
        // else
        // {
        //     Console.WriteLine("Invalid input! Please enter valid integers and ensure total is not zero.");
        // }

        // Console.WriteLine("\n--- BankAccount Demo ---");

        // // Create a BankAccount object with account number and initial balance
        // BankAccount account = new BankAccount("ACC123456", 1000.00);

        // // Display the account number (read-only property)
        // Console.WriteLine($"Account Number: {account.AccountNumber}");
        // Console.WriteLine($"Initial Balance: ${account.Balance}");

        // // Deposit money into the account
        // Console.WriteLine("\nDepositing $500...");
        // account.Deposit(500);

        // // Withdraw money from the account
        // Console.WriteLine("\nWithdrawing $300...");
        // account.Withdraw(300);

        // // Display the remaining balance
        // Console.WriteLine($"\nRemaining Balance: ${account.Balance}");

        // // Test validation: Try to withdraw more than available balance
        // Console.WriteLine("\nAttempting to withdraw $2000 (more than balance)...");
        // account.Withdraw(2000);

        // // Test validation: Try to deposit negative amount
        // Console.WriteLine("\nAttempting to deposit -$100 (negative amount)...");
        // account.Deposit(-100);

        // // Display final balance
        // Console.WriteLine($"\nFinal Balance: ${account.Balance}");

        // Console.WriteLine("\n--- Vehicle Inheritance Demo ---");

        // // Create an object of Car (derived class)
        // Car car = new Car("Toyota Camry", 180, 5);

        // // Create an object of Motorcycle (derived class)
        // Motorcycle motorcycle = new Motorcycle("Harley Davidson", 220, true);

        // // Demonstrate Car object
        // Console.WriteLine("\n--- Demonstrating Car ---");
        // // Call base class methods (code reusability)
        // car.Start();
        // car.Stop();
        // // Call overridden method to display car information
        // car.DisplayInfo();

        // // Demonstrate Motorcycle object
        // Console.WriteLine("\n--- Demonstrating Motorcycle ---");
        // // Call base class methods (code reusability)
        // motorcycle.Start();
        // motorcycle.Stop();
        // // Call overridden method to display motorcycle information
        // motorcycle.DisplayInfo();

        // // Demonstrate polymorphism - treating derived classes as base class
        // Console.WriteLine("\n--- Code Reusability Demo (Polymorphism) ---");
        // Vehicle vehicle1 = car;
        // Vehicle vehicle2 = motorcycle;

        // Console.WriteLine("\nCalling methods through base class reference:");
        // vehicle1.Start();
        // vehicle1.DisplayInfo();
        // Console.WriteLine();
        // vehicle2.Start();
        // vehicle2.DisplayInfo();

        // Console.WriteLine("\n--- Printer (Method Overloading) Demo ---");

        // // Create a Printer object
        // Printer printer = new Printer();

        // // Call the first overloaded method: Print(string message)
        // printer.Print("Hello, World!");

        // // Call the second overloaded method: Print(int number)
        // printer.Print(42);

        // // Call the third overloaded method: Print(string message, int count)
        // printer.Print("Good Morning", 3);

        // Console.WriteLine("\n--- Teacher (Method Overriding) Demo ---");

        // // Create an object of NepaliTeacher (derived class)
        // NepaliTeacher nepaliTeacher = new NepaliTeacher("Mr. Sharma");

        // // Create an object of EnglishTeacher (derived class)
        // EnglishTeacher englishTeacher = new EnglishTeacher("Ms. Smith");

        // // Demonstrate NepaliTeacher
        // Console.WriteLine("\n--- Nepali Teacher ---");
        // Console.WriteLine($"Teacher Name: {nepaliTeacher.Name}");
        // nepaliTeacher.Teaching(); // Calls overridden method
        // nepaliTeacher.SalaryInfo(); // Calls sealed method from base class

        // // Demonstrate EnglishTeacher
        // Console.WriteLine("\n--- English Teacher ---");
        // Console.WriteLine($"Teacher Name: {englishTeacher.Name}");
        // englishTeacher.Teaching(); // Calls base class method (not overridden)
        // englishTeacher.SalaryInfo(); // Calls sealed method from base class

        // // Demonstrate runtime polymorphism
        // Console.WriteLine("\n--- Runtime Polymorphism Demo ---");
        // Teacher teacher1 = nepaliTeacher;
        // Teacher teacher2 = englishTeacher;

        // Console.WriteLine("\nCalling methods through base class reference:");
        // teacher1.Teaching(); // Runtime polymorphism: calls NepaliTeacher's overridden method
        // teacher2.Teaching(); // Runtime polymorphism: calls base Teacher method

        // Console.WriteLine("\n--- Abstraction Demo ---");

        // // Create an object of AbstractCar (derived from abstract class)
        // AbstractCar car1 = new AbstractCar();

        // // Create an object of Bike (derived from abstract class)
        // Bike bike1 = new Bike();

        // // Demonstrate Car object
        // Console.WriteLine("\n--- Car Operations ---");
        // car1.Display(); // Call concrete method from abstract base class
        // car1.StartEngine(); // Call implemented abstract method
        // car1.StopEngine(); // Call implemented abstract method

        // // Demonstrate Bike object
        // Console.WriteLine("\n--- Bike Operations ---");
        // bike1.Display(); // Call concrete method from abstract base class
        // bike1.StartEngine(); // Call implemented abstract method
        // bike1.StopEngine(); // Call implemented abstract method

        // // Demonstrate abstraction through base class reference
        // Console.WriteLine("\n--- Abstraction with Base Class Reference ---");
        // AbstractVehicle vehicle3 = car1;
        // AbstractVehicle vehicle4 = bike1;

        // Console.WriteLine("\nUsing Car through AbstractVehicle reference:");
        // vehicle3.Display();
        // vehicle3.StartEngine();
        // vehicle3.StopEngine();

        // Console.WriteLine("\nUsing Bike through AbstractVehicle reference:");
        // vehicle4.Display();
        // vehicle4.StartEngine();
        // vehicle4.StopEngine();

        // Console.WriteLine("\n--- Electronics Store OOP Demo ---");

        // // Create an ElectronicsStore object
        // ElectronicsStore store = new ElectronicsStore();

        // Console.WriteLine("\n--- Creating Electronic Devices ---");

        // // Create Laptop objects with brand and price
        // Laptop laptop1 = new Laptop("Dell XPS 15", 1499.99);
        // Laptop laptop2 = new Laptop("MacBook Pro", 2399.99);

        // // Create Smartphone objects with brand and price
        // Smartphone smartphone1 = new Smartphone("iPhone 15 Pro", 999.99);
        // Smartphone smartphone2 = new Smartphone("Samsung Galaxy S24", 899.99);

        // Console.WriteLine("\n--- Adding Devices to Store ---");

        // // Add devices to the store
        // store.AddDevice(laptop1);
        // store.AddDevice(smartphone1);
        // store.AddDevice(laptop2);
        // store.AddDevice(smartphone2);

        // // Display all device details with child-specific behavior
        // store.ShowAllDeviceDetails();

        // Console.WriteLine("\n--- Demonstrating Encapsulation ---");
        // Console.WriteLine($"Accessing laptop brand through property: {laptop1.Brand}");
        // Console.WriteLine($"Accessing laptop price through property: ${laptop1.Price}");

        // Console.WriteLine("\n--- Removing a Device ---");
        // store.RemoveDevice(smartphone2);

        // Console.WriteLine("\n--- Updated Store Inventory ---");
        // store.ShowAllDeviceDetails();

        // Week 6 Assignments

        Console.WriteLine("\n--- Rectangle Expression-Bodied Members Demo ---");

        // Create a Rectangle object
        Rectangle rectangle = new Rectangle();

        // Set length and breadth using expression-bodied properties
        rectangle.Length = 10.5;
        rectangle.Breadth = 5.5;

        // Display rectangle details using expression-bodied method
        Console.WriteLine(rectangle.ShowDetails());

        // Calculate and display area using expression-bodied method
        double area = rectangle.GetArea();
        Console.WriteLine($"Area: {area} square units");

        // Calculate and display perimeter using expression-bodied method
        double perimeter = rectangle.GetPerimeter();
        Console.WriteLine($"Perimeter: {perimeter} units");

        // Create another rectangle with different dimensions
        Console.WriteLine("\n--- Second Rectangle ---");
        Rectangle rectangle2 = new Rectangle
        {
            Length = 8.0,
            Breadth = 6.0
        };

        Console.WriteLine(rectangle2.ShowDetails());
        Console.WriteLine($"Area: {rectangle2.GetArea()} square units");
        Console.WriteLine($"Perimeter: {rectangle2.GetPerimeter()} units");


    }
}