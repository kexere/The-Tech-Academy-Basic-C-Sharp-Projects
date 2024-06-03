using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a const variable
            const string const1 = "Hello ";
            Console.WriteLine("Enter your name or favorite number: ");
            //Create a variable using var keyword
            var answer = Console.ReadLine();

            if (float.TryParse(answer, out float x))
            {
                Console.Write(const1);
                Chain newChain = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                Console.Write(const1);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}
