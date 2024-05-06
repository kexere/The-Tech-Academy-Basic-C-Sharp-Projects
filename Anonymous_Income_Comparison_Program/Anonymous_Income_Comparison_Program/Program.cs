using System;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("\nPerson 1");
            Console.WriteLine("\nHourly rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("\nHours worked per week?");
            string hours1 = Console.ReadLine();

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("\nHours worked per week?");
            string hours2 = Console.ReadLine();

            //converts string to integer so that annual salary can be calculated by multiplying with 52
            int annualSalary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;
            Console.WriteLine("\nAnnual salary of Person 1: \n" + annualSalary1);

            //converts string to integer so that annual salary can be calculated by multiplying with 52
            int annualSalary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;
            Console.WriteLine("\nAnnual salary of Person 2: \n" + annualSalary2);

            //creates bool and compares Person1 salary with Person2 salary
            bool compareSalaries = annualSalary1 > annualSalary2;
            Console.WriteLine("\nPerson 1 makes more money than Person 2: \n" + compareSalaries);
            Console.ReadLine();

        }
    }
}
