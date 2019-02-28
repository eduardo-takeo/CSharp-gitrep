using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Entities;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> taxPayerList = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxPayerList.Add(new IndividualPerson(name, anualIncome, healthExpenditures));
                }
                else if (type == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employeeNumber = int.Parse(Console.ReadLine());
                    taxPayerList.Add(new JuridicalPerson(name, anualIncome, employeeNumber));
                }
                else
                {
                    return;
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double totalTax = 0;
            foreach (Person person in taxPayerList)
            {
                Console.WriteLine(person.Name + ": $ " + person.calculateTax(person.AnualIncome));
                totalTax += person.calculateTax(person.AnualIncome);
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + totalTax);
        }
    }
}
