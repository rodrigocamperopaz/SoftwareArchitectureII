using RefactoringII.FluentInterface;
using System.ComponentModel;

namespace RefactoringII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Fluent Interface");

            Console.WriteLine("Input option");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();

            switch (keyInfo.KeyChar)
            {
                case '1':
                    FluentInterfaceExample fluentInterfaceExample = new FluentInterfaceExample();
                    fluentInterfaceExample.Run();
                    break;
            }

            Console.ReadKey();
        }
    }
}
