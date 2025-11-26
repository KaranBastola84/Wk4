namespace Wk4.Wk5
{
    // Derived class: NepaliTeacher inherits from Teacher
    public class NepaliTeacher : Teacher
    {
        // Constructor
        public NepaliTeacher(string name) : base(name)
        {
        }

        // Override Teaching method to provide specific behavior for Nepali teacher
        public override void Teaching()
        {
            Console.WriteLine($"{Name} teaches in Nepali");
        }

        // Note: Cannot override SalaryInfo() because it is sealed in base class
    }
}
