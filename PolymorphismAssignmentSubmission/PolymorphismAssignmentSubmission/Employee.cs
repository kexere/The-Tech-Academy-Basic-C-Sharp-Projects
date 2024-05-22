using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmentSubmission
{
    //Inherits from Person class and IQuittable interface
    public class Employee : Person, IQuittable
    {
        //Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        //Implement the Quit() method from IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Press 'enter' to quit!");
            Console.ReadLine();
        }
    }
}
