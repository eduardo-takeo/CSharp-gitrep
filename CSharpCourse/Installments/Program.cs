using System;

namespace Installments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of installments: ");
            int installmentsNumber = int.Parse(Console.ReadLine());


        }
    }
}
