using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName=string.Empty;
            string lastName=string.Empty;

            Console.WriteLine("Input your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Input your last name:");
            lastName = Console.ReadLine();

            EmployeeProcessor processor = new EmployeeProcessor();
            string employeeId = processor.GenerateEmployeeId(firstName, lastName);

            Console.WriteLine($"Your employee id is: { employeeId }");
            Console.WriteLine($"Thank you {firstName} {lastName}");
            Console.ReadLine();
        }
    }
}
