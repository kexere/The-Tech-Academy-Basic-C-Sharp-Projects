using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //create string array
        string[] stringArray = { "Hello!", "Ola!", "Cau!", "Greetings!", "Hi there!" };
        //ask user for a number to display the string at that index
        Console.WriteLine("Please choose a number from 0 - 4:");
        int userChoice = Convert.ToInt32(Console.ReadLine()); //convert string to integer
        bool validString = false;

        while (!validString)
        {
            try
            {
                Console.WriteLine(stringArray[userChoice]);
                validString = true;
            }
            //add message to display if user picks non existant index
            catch
            {
                Console.WriteLine("Sorry, slected number is invalid. Please select a number from 0 - 4.");
                userChoice = Convert.ToInt32(Console.ReadLine());
            }
        }


        //create integer array
        int[] intArray = { 10, 33, 1, 3, 0, 20, 5 };
        //ask user for a number to display the string at that index
        Console.WriteLine("Please choose a number from 0 - 6:");
        int userChoice2 = Convert.ToInt32(Console.ReadLine()); //convert string to integer
        bool validInt = false;

        while (!validInt)
        {
            try
            {
                Console.WriteLine("You won " + intArray[userChoice2] + " dollars!");
                validInt = true;
            }
            //add message to display if user picks non existant index
            catch
            {
                Console.WriteLine("Sorry, slected number is invalid. Please select a number from 0 - 6.");
                userChoice2 = Convert.ToInt32(Console.ReadLine());
            }
        }

        //create list of strings
        List<string> stringList = new List<string>()
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        //ask user for a number to display the string at that index
        Console.WriteLine("Please choose a number from 0 - 6:");
        int userChoice3 = Convert.ToInt32(Console.ReadLine());
        bool validString2 = false;

        while (!validString2)
        {
            try
            {
                Console.WriteLine("Let's meet on " + stringList[userChoice3] + ".");
                validString2 = true;
            }
            //add message to display if user picks non existant index
            catch
            {
                Console.WriteLine("Sorry, slected number is invalid. Please select a number from 0 - 6.");
                userChoice3 = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.ReadLine();
    }
}