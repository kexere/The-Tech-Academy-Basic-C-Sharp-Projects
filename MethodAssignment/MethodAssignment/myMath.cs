using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class myMath
    {
        //Create a method that takes two integers as parameters
        //Make one paremeter optional by providing a default value
        public int MathOp1(int number, int number2 = 1)
        {
            //Perform addition on integers and return result
            int result = number + number2;
            return result;
        }
    }
}
