using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate myMath class
            myMath Math2 = new myMath();

            //Ask user to provide first parameter
            Console.WriteLine("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //Ask user to provide a second parameter or press enter
            Console.WriteLine("Enter a second integer, or just press enter: ");
            try
            {
                //Call method with 2 parameters if both parameters are provided
                int number2 = Convert.ToInt32(Console.ReadLine());
                int results = Math2.MathOp1(number, number2);
                Console.WriteLine(number + " + " + number2 + " = " + results);
            }
            catch
            {
                //Call method with one parameter if only one is provided
                int results = Math2.MathOp1(number);
                Console.WriteLine(number + " + Default 1 = " + results);
            }
            Console.ReadLine();

        }
    }
}
