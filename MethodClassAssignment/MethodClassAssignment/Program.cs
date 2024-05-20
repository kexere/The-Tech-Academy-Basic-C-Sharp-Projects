using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate MathOperation class
            MathOperation mathOp = new MathOperation();

            //Call the PerformOperation method with two integers
            mathOp.PerformOperation(10, 20);

            //Call the PerformOperation method with named parameters
            mathOp.PerformOperation(number1: 3, number2: 20);
            Console.ReadLine();
        }
    }
}
