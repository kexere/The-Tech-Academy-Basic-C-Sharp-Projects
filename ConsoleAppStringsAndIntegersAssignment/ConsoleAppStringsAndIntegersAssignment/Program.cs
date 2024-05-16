using System;
using System.Collections.Generic;

namespace ConsoleAppStringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers
            List<int> numbers = new List<int>() { 10, 20, 35, 46, 480, 220, 5048 };
            //Ask ther user to input number and loop through the list dividing each number by the input
            bool numValid = false;
            while (!numValid)
            {
                //Using a try / catch block to give error message
                try
                {
                    Console.WriteLine("Please write a number.");
                    float userNumber = float.Parse(Console.ReadLine());
                    //if statement to check if the user entered 0
                    if (userNumber == 0)
                    {
                        Console.WriteLine("Please enter a number other than 0.");
                    }
                    //Dividing each number in the list by the input
                    else
                    {
                        foreach (int number in numbers)
                        {
                            float result = number / userNumber;
                            Console.WriteLine(number + " / " + userNumber + " = " + result);
                        }
                    }
                }
                //Catch block to display error message for string input
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            //Message to let the user know the program has exited the try/catch block
            Console.WriteLine("The program has exited try/catch block.");
        }
    }
}
