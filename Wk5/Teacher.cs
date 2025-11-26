namespace Wk4.Wk5
{
    // Base class Teacher
    public class Teacher
    {
        // Property: Teacher's name
        public string Name { get; set; }

        // Constructor to initialize teacher's name
        public Teacher(string name)
        {
            Name = name;
        }

        // Virtual method: Can be overridden by derived classes
        public virtual void Teaching()
        {
            Console.WriteLine($"{Name} teaches in English");
        }

        // Sealed method: Cannot be overridden by any child classes
        public sealed void SalaryInfo()
        {
            Console.WriteLine($"{Name}'s salary information is confidential and follows school policy.");
        }
    }
}
