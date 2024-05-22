using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with firstName “Sample” and lastName “Student”
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            //Call the SayName() method on the object
            employee.SayName();
            //Use polymorphism to create an object of type IQuittable
            IQuittable quittable = employee;
            // Call the Quit() method on the IQuittable object
            quittable.Quit();
        }
    }
}
