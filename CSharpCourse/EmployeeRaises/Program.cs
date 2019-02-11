using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            List<Employee> employeeList = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                id = Convert.ToInt16(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                
                employeeList.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee ID that will have salary increase: ");
            id = Convert.ToInt16(Console.ReadLine());

            bool idExists = employeeList.Any(employee => employee.Id == id);
            if (idExists == false)
            {
                Console.WriteLine("ID Not Found");
                Console.ReadLine();
                return;
            }
            else
            {
                Employee employeeToRaise = employeeList.Find(employee => employee.Id == id);
                Console.Write("Enter the percentage: ");
                double percentage = Convert.ToDouble(Console.ReadLine());
                employeeToRaise.Raise(id, percentage);
            }                    

            Console.WriteLine("Updated list of employees: ");
            foreach (var employee in employeeList)
            {
                Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Salary}");
            }
            Console.ReadLine();
        }
    }
}
