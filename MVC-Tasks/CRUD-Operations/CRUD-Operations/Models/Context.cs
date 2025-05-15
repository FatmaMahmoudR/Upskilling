using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Diagnostics;

namespace CRUD_Operations.Models
{
    public class Context :DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = FATMA\\MSSQLSERVERR; initial catalog= CompanyMVC; trust server certificate=true; Integrated Security = True").LogTo(l => Debug.WriteLine(l));
        }
    }
}
