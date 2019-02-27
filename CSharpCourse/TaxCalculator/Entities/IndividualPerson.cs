using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Entities
{
    class IndividualPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public IndividualPerson()
        {

        }

        public IndividualPerson(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double calculateTax(double anualIncome)
        {            
            if (anualIncome < 2000)
            {
                return (anualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (anualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
