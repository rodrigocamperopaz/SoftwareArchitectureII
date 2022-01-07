namespace RefactoringII.FluentInterface
{
    public class FluentEmployee
    {
        private readonly Employee _employee = new Employee();

        public FluentEmployee(Employee employee)
        {
            _employee = employee;
        }

        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            _employee.FullName = FullName;
            return this;
        }
        public FluentEmployee Born(string DateOfBirth)
        {
            _employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }
        public FluentEmployee WorkingOn(string Department)
        {
            _employee.Department = Department;
            return this;
        }
        public FluentEmployee StaysAt(string Address)
        {
            _employee.Address = Address;
            return this;
        }

        public Employee Employee
        {
            get { return _employee; }
        }
    }
}
