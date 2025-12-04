namespace Wk4.Wk6
{
    // Student class for sorting example
    public class Student
    {
        public string Name { get; set; }
        public string StudentId { get; set; }
        public double GPA { get; set; }

        public Student(string name, string studentId, double gpa)
        {
            Name = name;
            StudentId = studentId;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"{Name} (ID: {StudentId}, GPA: {GPA})";
        }
    }
}
