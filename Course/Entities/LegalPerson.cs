using System;
using System.Globalization;

namespace Course.Entities.Enum
{
    class LegalPerson : Contributor
    {
        public double EmployeesNumber { get; set; }

        public LegalPerson(string name, double annualIncome, double employeesNumber) : base(name, annualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public LegalPerson()
        {
        }

        public override double Tax()
        {
            if(EmployeesNumber > 10)
            {
                return AnnualIncome * 0.16;
            }
            else
            {
                return AnnualIncome * 0.14;
            }
            
        }
    }
}
