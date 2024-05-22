using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        //Create an enum for the days of the week
        public enum weekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            bool isvalid = false;
            while (!isvalid)
            {
                try
                {
                    //Prompt the user to enter the current day of the week
                    Console.WriteLine("Please enter the current day of the week: ");
                    string userDay = Console.ReadLine();
                    //Assign the value to a variable of that enum data type you just created
                    weekDays day = (weekDays)Enum.Parse(typeof(weekDays), userDay);
                    Console.WriteLine("Have a nice " + day);
                    Console.ReadLine();
                    isvalid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
        }

    }


}
