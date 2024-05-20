using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class myMath
    {
        //First method that takes an integer from user input
        public int MathOp(int number)
        {
            return number + 10;
        }

        //Second method that takes a decimal from user input
        public int MathOp(decimal number)
        {
            //Convert the decimal to an int to perform math operation
            int number2 = Convert.ToInt32(number);
            return number2 * 30;
        }

        //Third method that takes a string
        public int MathOp(string number)
        {
            //Convert the string to an integer to perform math operation
            int number2 = Convert.ToInt32(number);
            return number2 / 10;
        }
    }
}
