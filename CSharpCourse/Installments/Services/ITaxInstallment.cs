using System;
namespace Installments.Services
{
    interface ITaxInstallment
    {
        double MSI(double monthlySimpleInterest);
        double PF(double paymentFee);
    }
}
