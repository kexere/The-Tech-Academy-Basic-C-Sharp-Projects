using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("The current time is : " + today); //writes todays date
            //Ask user for a number
            Console.WriteLine("\nEnter a number to see what the time will be in that many hours: ");
            //Convert user number to integer
            int userNumber = Convert.ToInt32(Console.ReadLine());
            //creates a time interval from userNumber
            TimeSpan duration = new TimeSpan(0, userNumber, 0, 0);
            //Adds X hours to todays date
            DateTime answer = today.Add(duration);
            //Prints to the console the exact time it will be in X hours, X being the number the user entered
            Console.WriteLine("In {0} hours the new date will be {1}", userNumber, answer);
            Console.ReadLine();
        }
    }
}
