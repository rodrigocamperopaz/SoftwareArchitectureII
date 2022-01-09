using RefactoringII.FluentInterface;
using System.ComponentModel;

namespace RefactoringII
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitLoop = false;
            Console.WriteLine("1. Employee Fluent Interface");
            Console.WriteLine("2. Item Fluent Interface");
            Console.WriteLine("3. Order Fluent Interface");
            Console.WriteLine("0. Exit");

            while (!exitLoop)
            {
                Console.WriteLine("Input option");

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                Console.WriteLine();
                Console.WriteLine();

                switch (keyInfo.KeyChar)
                {
                    case '1':
                        FluentInterfaceExample.RunEmployeeExample();
                        break;
                    case '2':
                        FluentInterfaceExample.RunItemExample();
                        break;
                    case '3':
                        FluentInterfaceExample.RunOrderExample();
                        break;
                    case '0':
                        exitLoop = true;
                        Console.WriteLine("Bye!");
                        break;
                }
            }
        }
    }
}
