using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are participating in kickbox fight.");
            Console.WriteLine("Input your defense stat:");
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = MathMethods.Defense(defense);
            Console.WriteLine("You have taken " + enemy_damage + " HP of damage.");
            Console.WriteLine("You find a medicine pouch in your pocket. It heals some of your damage.");
            Console.WriteLine("Input your medicine pouch stat:");
            int medicine = Convert.ToInt32(Console.ReadLine());
            int getBetter = MathMethods.Health(medicine);
            Console.WriteLine("You have been healed by " + getBetter + " HP.");
            Console.WriteLine("Now it is your turn to attack.");
            Console.WriteLine("Input your strength stat:");
            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethods.Attack(strength);
            Console.WriteLine("Your attack dealt " + damage + " HP worth of damage.");
            Console.ReadLine();
        }
    }
}
