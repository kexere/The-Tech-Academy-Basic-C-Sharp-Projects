using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class MathMethods
    {
        //create three methods that take one integer parameter and return integer
        //method 1
        public static int Attack(int strength)
        {
            Random rnd = new Random();
            int enemy_def = rnd.Next(1, 50); //creates random number between 1 and 50
            int punch_str = rnd.Next(10, 100);
            int kick_str = rnd.Next(10, 100);
            int combo_bonus = rnd.Next(20, 60);
            int crit_chance = rnd.Next(1, 2);
            int damage = (strength + (punch_str + kick_str) - enemy_def) * crit_chance;
            return damage;
        }
        //method 2
        public static int Defense(int defense)
        {
            Random rnd = new Random();
            int enemy_str = rnd.Next(1, 50); //creates random number between 1 and 50
            int punch_str = rnd.Next(10, 100);
            int kick_str = rnd.Next(10, 100);
            int combo_bonus = rnd.Next(20, 60);
            int crit_chance = rnd.Next(1, 2);
            int enemy_damage = (enemy_str + (punch_str + kick_str) - defense) * crit_chance;
            return enemy_damage;
        }

        //method 3 
        public static int Health(int medicine)
        {
            Random rnd = new Random();
            int getBetter = medicine - rnd.Next(1, medicine);
            return getBetter;
        }
    }
}
