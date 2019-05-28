using System;
namespace Installments.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public int InstallmentsNumber { get; set; }

        public Contract(int number, DateTime date, double totalValue, int installmentsNumber)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            InstallmentsNumber = installmentsNumber;
        }
    }
}
