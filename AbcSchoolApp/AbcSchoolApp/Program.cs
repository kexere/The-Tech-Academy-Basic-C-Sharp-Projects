using AbcSchoolApp;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;

namespace AbcSchoolApp.Models
{
    class Program
    {
         public static void Main(string[] args)
         {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Elsa"};
                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.Write("Student saved successfully!\n");

                foreach (var student in ctx.Students.ToList())
                {
                    Console.WriteLine($"Student ID: {student.StudentId}, Name: {student.StudentName}");
                }

            }
         }
    }
}