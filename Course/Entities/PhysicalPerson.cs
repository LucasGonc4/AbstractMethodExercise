using System;
using System.Globalization;

namespace Course.Entities.Enum
{
    class PhysicalPerson : Contributor
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }
        public double EmployeesNumber { get; set; }

        public PhysicalPerson(string name, double annualIncome, double employeesNumber) : base(name, annualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public PhysicalPerson()
        {
        }

        public override double Tax()
        {
            throw new NotImplementedException();
        }
    }
}
