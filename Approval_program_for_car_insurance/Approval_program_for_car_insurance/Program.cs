using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval_program_for_car_insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");

            Console.WriteLine("\nWhat is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); //converts string to integer

            Console.WriteLine("\nHave you ever had a DUI? Please answer with yes on no.");
            string dui = Console.ReadLine().ToLower(); //converts answer to lower letters
            bool duiAnswer = dui == "yes"; //checks if person have a DUI

            Console.WriteLine("\nHow many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine()); //converts string to integer

            bool qualified = (age > 15) && !duiAnswer && (speedingTickets <= 3); //checks if person is qualified

            Console.WriteLine("\nQualified?");
            Console.WriteLine(qualified);

            Console.ReadLine();

        }
    }
}
