using System;
using System.Globalization;

namespace Course.Entities.Enum
{
    class LegalPerson : Contributor
    {
        public string Name { get; set; }

        public double AnnualIncome { get; set; }

        public double HealhExpenses { get; set; }

        public LegalPerson(string name, double annualIncome, double healhExpenses) : base(name, annualIncome)
        {
            HealhExpenses = healhExpenses;
        }

        public LegalPerson()
        {
        }

        public override double Tax()
        {
            throw new NotImplementedException();
        }
    }
}
