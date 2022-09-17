using System;
using System.Globalization;

namespace Course.Entities.Enum
{
    class PhysicalPerson : Contributor
    {
        public double HealhExpenses { get; set; }

        public PhysicalPerson(string name, double annualIncome, double healhExpenses) : base(name, annualIncome)
        {
            HealhExpenses = healhExpenses;
        }

        public PhysicalPerson(string name, double annualIncome) : base(name, annualIncome)
        {           
        }

        public PhysicalPerson()
        {
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000)
            {
                return (AnnualIncome * 0.15);
            }
            else if (AnnualIncome >= 20000)
            {
                return (AnnualIncome * 0.25);
            }
            else if (AnnualIncome < 20000 && HealhExpenses != 0)
            {
                return (AnnualIncome * 0.15) - (HealhExpenses * 0.5);
            }
            else if (AnnualIncome >= 20000 && HealhExpenses != 0)
            {
                return (AnnualIncome * 0.25) - (HealhExpenses * 0.5);
            }
            else
            {
                return 0;
            }
        }
    }
}
