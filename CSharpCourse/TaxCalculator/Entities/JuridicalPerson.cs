using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Entities
{
    class JuridicalPerson : Person
    {
        public int EmployeeNumber { get; set; }

        public JuridicalPerson()
        {

        }

        public JuridicalPerson(string name, double anualIncome, int employeeNumber) : base(name, anualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double calculateTax(double anualIncome)
        {
            if (EmployeeNumber > 10)
            {
                return anualIncome * 0.14;                
            }
            else
            {
                return anualIncome * 0.16;
            }   
        }
    }
}
