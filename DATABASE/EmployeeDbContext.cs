

using CRUDAPPLICATION.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPPLICATION.DATABASE
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> opt) : base(opt)
        {

        }
        public DbSet<EmployeeProfile> employeeProfiles { get; set; } = null;
    }

}
