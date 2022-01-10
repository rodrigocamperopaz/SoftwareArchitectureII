using System.ComponentModel;

namespace RefactoringII.FluentInterface
{
    public class FluentInterfaceExample
    {
        public void Run()
        {
            Employee employee = GetEmployee();

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(employee))
            {
                string name = descriptor.Name;
                object? value = descriptor.GetValue(employee);
                Console.WriteLine($"{name}={value}");
            }

            Console.WriteLine("----------------------------------------------");

            FluentEmployee fluentEmployee = GetFluentEmployee(employee);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(fluentEmployee.Employee))
            {
                string name = descriptor.Name;
                object? value = descriptor.GetValue(fluentEmployee.Employee);
                Console.WriteLine($"{name}={value}");
            }
        }

        private Employee GetEmployee()
        {
            Employee employee = new Employee
            {
                Address = "add",
                Department = "resistance",
                FullName = "Kyle Reese",
                DateOfBirth = DateTime.Now
            };

            return employee;
        }

        private FluentEmployee GetFluentEmployee(Employee employee)
        {
            FluentEmployee fluentEmployee = new FluentEmployee(employee);

            fluentEmployee.NameOfTheEmployee("Sarah Connor")
                .Born("10/10/1970")
                .WorkingOn("Waitress")
                .StaysAt("Chicago");

            return fluentEmployee;
        }
        private FluentHistory GetFluentHistory(History history)
        {
            FluentHistory fluentHistory = new FluentHistory(history);

            fluentHistory.LastBusiness("BNB")
                .LastJob("10/10/1970")
                .Salary(2000);

            return fluentHistory;
        }


    }
}
