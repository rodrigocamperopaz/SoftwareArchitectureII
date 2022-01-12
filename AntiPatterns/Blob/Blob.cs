namespace AntiPatterns.Blob
{
    /*
        Violation of Single Responsibility Principle 
        This class is doing everything. The functionalities of class should be separated into other different classes and interfaces based on similar type of responsibilities. 
        It will remove the issue of tight coupling and will be easy for maintainability.

        Opposing Design Pattern
        It is not following any design pattern principle. Code can't be reused. It is prone to copy-paste for the same.

        Missing Abstraction
        This class is missing an abstraction, so writing unit tests will be very difficult. It will expose all members of class.
     */
    public class Blob
    {
        public void FetchEmployeeDetails(string employeeId) { }
        public void SaveEmployeeDetails(EmployeeModel employeeDetails) { }
        public void ValidateEmployeeDetails(EmployeeModel employeeDetails) { }
        public void ExportEmpDetailsToCSV(EmployeeModel employeDetails) { }
        public void ImportEmpDetailsForDb(EmployeeModel employeeDetails) { }
        public class EmployeeModel
        {
            public string EmployeeId
            {
                get;
                set;
            }
            public string EmployeeName
            {
                get;
                set;
            }
            public string EmpplyeeAddress
            {
                get;
                set;
            }
            public string EmployeeDesignation
            {
                get;
                set;
            }
            public double EmployeeSalary
            {
                get;
                set;
            }
        }
    }
}
