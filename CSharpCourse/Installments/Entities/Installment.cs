    using System;
namespace Installments.Entities
{
    public class Installment
    {
        public DateTime Date { get; set; }
        public int Number { get; set; }
        public double InstallmentValue { get; set; }

        public Installment(DateTime date, int number, double installmentValue)
        {
            Date = date;
            Number = number;
            InstallmentValue = installmentValue;
        }

        public double CalculateInstallment(double installmentValue, int installmentNumber)
        {
            double result = installmentValue + (installmentValue * 0.01) * installmentNumber;
            result += (result * 0.02);
            return result;
        }
    }
}