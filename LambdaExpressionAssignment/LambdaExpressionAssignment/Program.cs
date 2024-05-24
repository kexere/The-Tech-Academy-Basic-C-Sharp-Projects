using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create a list of at least 10 employees. At least two employees should have the first name “Joe”.
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id = 1, firstName = "Joe", lastName = "Adams" },
                new Employee() {Id = 2, firstName = "Anna", lastName = "Panna" },
                new Employee() {Id = 3, firstName = "Adam", lastName = "Levine"},
                new Employee() {Id = 4, firstName = "Joe", lastName = "Silver" },
                new Employee() {Id = 5, firstName = "Lisa", lastName = "Simpson" },
                new Employee() {Id = 6, firstName = "John", lastName = "Winchester" },
                new Employee() {Id = 7, firstName = "Ben", lastName = "Affleck"},
                new Employee() {Id = 8, firstName = "Kate", lastName = "Hudson"},
                new Employee() {Id = 9, firstName = "Susan", lastName = "Burn"},
                new Employee() {Id = 10, firstName = "Karen", lastName = "Stevens"}
            };
            //Using a foreach loop, create a new list of all employees with the first name “Joe”.
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            //Perform the same action again, but this time with a lambda expression.
            List<Employee> joes1 = employees.Where(x => x.firstName == "Joe").ToList();
            //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> id5 = employees.Where(y => y.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}
