using System;
using Course.Entities.Enum;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contributor> list = new List<Contributor>();

            Console.Write("Enter the number of payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Tax payer #{i} data");

                Console.Write("Name: ");
                string name = Console.ReadLine();            

                Console.Write("Individual or company?: ");
                char c = char.Parse(Console.ReadLine());

                Console.Write("Annual income: ");
                double annualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                              
                if(c == 'c' || c == 'C')
                {
                    Console.Write("Number of employees: ");
                    int numberemp = int.Parse(Console.ReadLine());

                    list.Add(new LegalPerson(name, annualincome, numberemp));
                }
                else
                {
                    Console.Write("Have health expenses(y/n)?: ");
                    char he = char.Parse(Console.ReadLine());

                    if(he == 'y' || he == 'Y')
                    {
                        double healthexpeditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        list.Add(new PhysicalPerson(name, annualincome, healthexpeditures));
                    }
                    else
                    {                        
                        list.Add(new PhysicalPerson(name,annualincome));
                    }
                }             
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (Contributor obj in list)
            {
                Console.WriteLine(obj.Name + ", " + obj.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: ");
            double sum = 0;
            foreach (Contributor obj in list)
            {
                sum += obj.Tax();
                Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
