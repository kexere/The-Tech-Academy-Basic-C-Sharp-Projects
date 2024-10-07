using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchoolApp
{
    internal class SchoolContext : DbContext
    {
        public SchoolContext(): base(@"Server=(localdb)\MSSQLLocalDB;Database=SchoolDB;Trusted_Connection=True;")
        { 

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
