using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class PremiumAccount : Account
    {
        public bool Loan { get; set; }

        public PremiumAccount(bool loan) : base(Number, Owner)
        {
            Loan = loan;
        }
    }
}
