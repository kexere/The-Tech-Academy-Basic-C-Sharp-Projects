using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    //Create an Employee class with Id, FirstName and LastName properties
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Overload the == operator to compare Employee objects by Id
        public static bool operator== (Employee emp1, Employee emp2)
        {
            // Check if both objects are null or the same instance
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // If one is null but not the other, they are not equal
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }

            // Compare the Id properties for equality
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator to compare Employee objects by Id
        public static bool operator!= (Employee emp1, Employee emp2)
        {
            // Use the overloaded == operator to determine inequality
            return !(emp1 == emp2);
        }

        // Override Equals to ensure consistency with the overloaded operators
        public override bool Equals(object obj)
        {
            // Check if the passed object is an Employee
            if (obj is Employee)
            {
                // Use the == operator for comparison
                return this == (Employee)obj;
            }

            // If the object is not an Employee, return false
            return false;
        }

        // Override GetHashCode to maintain consistency with Equals
        public override int GetHashCode()
        {
            // Return the hash code of the Id property
            return Id.GetHashCode();
        }
    }
}
