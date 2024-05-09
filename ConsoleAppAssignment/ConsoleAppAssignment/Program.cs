using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            //this is a do while loop
            Console.WriteLine("Guess a color!");
            string color = Console.ReadLine().ToLower();
            bool isGuessed = false;

            do
            {
                switch (color)
                {
                    case "blue":
                        Console.WriteLine("You guessed blue. Try again.");
                        Console.WriteLine("Guess a color!");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow. Try again.");
                        Console.WriteLine("Guess a color!");
                        color = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed red. Try again.");
                        Console.WriteLine("Guess a color!");
                        color = Console.ReadLine();
                        break;
                    case "Green":
                        Console.WriteLine("Use small caps!");
                        Console.WriteLine("Guess a color!");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black; // Set foreground color for visibility
                        Console.Clear(); // Clear console to set background color
                        Console.WriteLine("You guessed color green. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a color!");
                        color = Console.ReadLine();
                        break;
                }
            }

            while (!isGuessed); //continue loop until it is true

            Console.Read();
        }
    }
}
