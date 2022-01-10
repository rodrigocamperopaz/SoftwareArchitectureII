namespace RefactoringII.FluentInterface
{
    public class FluentHistory
    {
        private readonly History _history = new History();

        public FluentHistory(History history)
        {
            _history = history;
        }

        public FluentHistory LastBusiness(string Business)
        {
            _history.Business = Business;
            return this;
        }
        public FluentHistory LastJob(string Department)
        {
            _history.Department = Department;
            return this;
        }
        public FluentHistory Salary(int Salary)
        {
            _history.Salary = Salary;
            return this;
        }
        public History History
        {
            get { return _history; }
        }
    }
}
