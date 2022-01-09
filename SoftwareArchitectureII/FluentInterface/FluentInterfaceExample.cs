using System.Collections;
using System.ComponentModel;

namespace RefactoringII.FluentInterface
{
    public class FluentInterfaceExample
    {

        #region Employee

        public static void RunEmployeeExample()
        {
            Employee employee = GetEmployee();

            PrintObjectInfo(employee);
            Console.WriteLine("----------------------------------------------\n");

            FluentEmployee fluentEmployee = GetFluentEmployee(employee);

            PrintObjectInfo(fluentEmployee.Employee);
            Console.WriteLine("----------------------------------------------\n");
        }

        private static Employee GetEmployee()
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

        private static FluentEmployee GetFluentEmployee(Employee employee)
        {
            FluentEmployee fluentEmployee = new FluentEmployee(employee);

            fluentEmployee
                .NameOfTheEmployee("Sarah Connor")
                .Born("10/10/1970")
                .WorkingOn("Waitress")
                .StaysAt("Chicago");

            return fluentEmployee;
        }
        #endregion

        #region Item

        public static void RunItemExample()
        {
            Item item = GetItem();

            PrintObjectInfo(item);
            Console.WriteLine("----------------------------------------------\n");

            FluentItem fluentItem = GetFluentItem(item);

            PrintObjectInfo(fluentItem.Item);
            Console.WriteLine("----------------------------------------------\n");
        }

        private static Item GetItem()
        {
            Item item = new Item
            {
                Id = "0005",
                Name = "Mouse",
            };

            return item;
        }

        private static FluentItem GetFluentItem(Item item)
        {
            FluentItem fluentItem = new FluentItem(item);

            fluentItem
                .IdOfTheItem("0010")
                .NameOfTheItem("Keyboard");

            return fluentItem;
        }
        #endregion

        #region Order

        public static void RunOrderExample()
        {
            Order order = GetOrder();

            PrintObjectInfo(order);
            Console.WriteLine("----------------------------------------------\n");

            FluentOrder fluentOrder = GetFluentOrder(new Order());

            PrintObjectInfo(fluentOrder.Order);
            Console.WriteLine("----------------------------------------------\n");
        }

        private static Order GetOrder()
        {
            Order order = new Order
            {
                Id = 100,
                Items =
                {
                    new Item
                    {
                        Id = "0005",
                        Name = "Mouse"
                    },
                    new Item
                    {
                        Id = "0010",
                        Name = "Keyboard"
                    },
                }
            };

            return order;
        }

        private static FluentOrder GetFluentOrder(Order order)
        {
            FluentOrder fluentOrder = new FluentOrder(order);

            FluentItem fluentItem0 = new FluentItem(new Item());
            FluentItem fluentItem1 = new FluentItem(new Item());
            fluentItem0
                .IdOfTheItem("0010")
                .NameOfTheItem("Keyboard");
            fluentItem1
                .IdOfTheItem("0005")
                .NameOfTheItem("Mouse");

            fluentOrder
                .IdOfTheOrder(200)
                .AddItem(fluentItem0.Item)
                .AddItem(fluentItem1.Item);

            return fluentOrder;
        }
        #endregion

        private static void PrintObjectInfo(object obj)
        {
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                string name = descriptor.Name;
                object? value = descriptor.GetValue(obj);

                if (value != null)
                {
                    if (value is IList)
                    {
                        Type type = value.GetType().GetGenericArguments()[0];
                        Console.WriteLine($"{type.Name}'s List:");
                        foreach (object item in (IList)value)
                        {
                            PrintObjectInfo(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{name}={value}");
                    }
                }
                else
                {
                    throw new Exception("Descriptor get a NULL value.");
                }
            }
        }
    }
}
