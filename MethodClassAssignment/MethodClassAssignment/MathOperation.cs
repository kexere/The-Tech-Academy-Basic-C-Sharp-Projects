using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class MathOperation
    {
        //Create void method that takes two integers as paremeters
      public void PerformOperation(int number1, int number2)
      {
            // Perform a math operation on the first integer
            int result = number1 * 2;
            // Display the second integer to the screen
            Console.WriteLine("The second integer is: " + number2);
        }
    }
}
