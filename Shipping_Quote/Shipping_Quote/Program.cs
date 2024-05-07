using System;

namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("\nPlease enter the package weight:");
            float weight = float.Parse(Console.ReadLine()); //convert string to float
            if (weight > 50) //ends program if weight bigger than 50
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nPlease enter the package width:");
                float width = float.Parse(Console.ReadLine()); //converts string to float
                Console.WriteLine("\nPlease enter the package height:");
                float height = float.Parse(Console.ReadLine()); //converts string to float
                Console.WriteLine("\nPlease enter the package length:");
                float length = float.Parse(Console.ReadLine()); //converts string to float

                float dimensionsTotal = width + height + length; //calculates total dimensions
                if (dimensionsTotal > 50) //ends program if total dimensions is bigger than 50
                {
                    Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    float quote = width * height * length * weight / 100; //calculates quote
                    //adds dollar sign and two number after dot for quote amount.
                    Console.WriteLine("\nYour estimated total for shipping this package is: ${0}", quote.ToString("0.00"));
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
