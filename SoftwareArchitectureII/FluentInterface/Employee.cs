namespace RefactoringII.FluentInterface
{
    public class Employee
    {
        public string? FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Department { get; set; }
        public string? Address { get; set; }

        public Employee()
        {

        }

        public Employee(string? fullName, DateTime dateOfBirth, string? department, string? address)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Department = department;
            Address = address;
        }
    }
}
