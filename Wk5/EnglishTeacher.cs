namespace Wk4.Wk5
{
    // Derived class: EnglishTeacher inherits from Teacher
    public class EnglishTeacher : Teacher
    {
        // Constructor
        public EnglishTeacher(string name) : base(name)
        {
        }

        // Note: Does NOT override Teaching() method
        // Will use the base class implementation
        // This demonstrates that overriding is optional for virtual methods

        // Note: Cannot override SalaryInfo() because it is sealed in base class
    }
}
