using System;
namespace Installments.Services
{
    public class BrazilTaxInstallment : ITaxInstallment
    {
        public double MSI(double monthlySimpleInterest)
        {
            return 0.01;
        }

        public double PF(double paymentFee)
        {
            return 0.02;
        }
    }
}
