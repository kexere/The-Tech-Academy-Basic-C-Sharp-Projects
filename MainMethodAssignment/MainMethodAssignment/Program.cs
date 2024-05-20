using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Math class
            myMath math1 = new myMath();
            //Call the first method with an int parameter
            Console.WriteLine(math1.MathOp(10));
            //Call the second method with a decimal parameter
            Console.WriteLine(math1.MathOp(10.5m));
            //Call a third method with a string parameter
            Console.WriteLine(math1.MathOp("10"));
            Console.ReadLine();
        }
    }
}
