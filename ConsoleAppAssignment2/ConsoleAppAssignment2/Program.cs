using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment Part 1
            //create a one- dimensional array of strings
            string[] stringArray = { 
                "yellow", 
                "green", 
                "red", 
                "purple", 
                "blue"
            };
            //ask user to input some text
            Console.WriteLine("Please write something:");
            string userInput = Console.ReadLine();
            //loop that adds user's text input to the end of each string at stringArray
            for (int i = 0; i < stringArray.Length; i++ )
            {
                stringArray[i] = stringArray[i] + " " + userInput;
            }
            //seconds loop that prints off each string in the array one at a time
            for (int j = 0; j < stringArray.Length; j++)
            {
                Console.WriteLine(stringArray[j]);
            }

            //Assignment Part 2
            //this loop will run indefinitely because the condition "true" is always true
            //to fix this, condition that allows the loop to break is added
            while (true)
            {
                Console.WriteLine("\nType 'exit' to quit: ");
                string inputString = Console.ReadLine();

                if (inputString.ToLower() == "exit")
                {
                    //break out of the loop if user inputs "exit"
                    break;
                }
                //Echo back the input string
                Console.WriteLine("You entered: " + inputString);
            }

            //Assignment Part 3
            //loop using "<" operator
            Console.WriteLine("\nLoop using '<' operator:");
            for (int m = 0; m < 5; m++)
            {
                Console.WriteLine("Iteration " + (m + 1));
            }

            //loop using "<=" operator
            Console.WriteLine("\nLoop using '<=' operator:");
            for (int k = 0; k <= 5; k++)
            {
                Console.WriteLine("Iteration " + (k + 1));
            }

            //Assignment Part 4
            // list of strings where each item in the list is unique
            List<string> fruits = new List<string>()
            { "apple", "banana", "strawberry", "raspberry", "kiwi", "pear", "melon"};
            //asks the user to input text to search for in the list
            Console.WriteLine("\nWe have a delicious fruit shop. \nPlease write a fruit name to check if it is in stock: ");
            string searchFruit = Console.ReadLine().ToLower();
            bool foundMatch = false; //flag to track if a match has been found

            //a loop that iterates through the list and displays the index of the list item that contains matching text
            for (int f = 0; f < fruits.Count; f++)
            {
                if (fruits[f].Contains(searchFruit))
                {
                    Console.WriteLine(searchFruit + " found at shelf " + f); //displays index of the searched item
                    foundMatch = true; //set flag to true if match is found
                    break; //exit the loop once a match is found
                }

            }
            if (!foundMatch)
            {
                Console.WriteLine("We don't sell those!"); //tells user the input is not one the list
            }

            //Assignment Part 5
            //list of strings with two identical strings
            List<string> months = new List<string>()
            { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october",
              "november", "december", "january"};

            //ask the user to select text to search for in the list
            Console.WriteLine("\nType your favorite month: ");
            string userMonth = Console.ReadLine().ToLower();

            //loop that iterates through the list and displays the indices of the list that contain matching text
            bool foundMatch2 = false; //flag to track if any match is found

            for (int x = 0; x < months.Count; x++)
            {
                if (months[x].Contains(userMonth))
                {
                    Console.WriteLine("Your favorite month is found at index " + x);
                    foundMatch2 = true; //set flag to true if match is found
                }
            }

            //check if any match is found
            if (!foundMatch2)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            //Asignment Part 6
            //list of strings with two identical strings
            List<string> cities = new List<string>()
            { "peterborough", "london", "riga", "birmingham", "london", "madrid"};
            List<string> duplicates = new List<string>();
            Console.WriteLine("\nCities to visit:");
            //create foreach loop that evaluates each item in the list and displays a message showing the string
            //and if it has already apeared on the list
            foreach (string city in cities)
            {
                Console.Write("\n" + city);
                if (duplicates.Contains(city))
                {
                    Console.Write(" - this city was visited. Choose another city to visit!");
                }
                else
                {
                    Console.Write(" - this city has not been visited.");
                }
                duplicates.Add(city);
            }
            Console.ReadLine();
        }
    }
}
