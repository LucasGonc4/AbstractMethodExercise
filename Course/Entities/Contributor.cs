using System;
using System.Globalization;

namespace Course.Entities.Enum
{
    abstract class Contributor
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }


        public Contributor()
        {
        }

        public Contributor(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
        
    }
}
