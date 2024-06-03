using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Chain
    {
        string Name { get; set; }
        float Num { get; set; }
        static Random random = new Random();

        //Constructor if one parameter, a float, is provided
        public Chain(float num1) : this(num1, "Mistery Person")
        {
            Console.Write(Name + ", your favorite number is " + num1);
        }
        //Constructor if one parameter, a string, is provided
        public Chain(string name1) : this(random.Next(0, 100), name1)
        {
            Console.Write(name1 + ", your favorite random number is " + Num);
        }
        //Constructor if both parameters, a string and a float, are provided
        public Chain(float num, string name)
        {
            Name = name;
            Num = num;
        }

    }
}
