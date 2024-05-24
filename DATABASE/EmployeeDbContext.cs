using CRUDAPPLICATION.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPPLICATION.DATABASE
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }

     
        public DbSet<EmployeeProfile> employeeProfiles { get; set;} 
        public DbSet<CustomerPrice> customerPrices { get; set;}
        public DbSet<StateModel> states { get; set;}  
        public DbSet<City> citys { get; set;}
        public DbSet<EmployeeQuery> employeeQuery { get; set;}
        public DbSet<Country> countries { get; set;}
        public DbSet<Department> department { get; set;}
        public DbSet<DesignationModel> designations { get; set; }
        public DbSet<Gender> gender { get; set;}
        //public DbSet<HRLOGIN> hrlogin { get; set; }
        //public DbSet<AdminLogin> adminlogin { get; set; }
        //public DbSet<EmployeeLogin> EmployeeLogins { get; set; }
        public DbSet<RelationModel> relationModels { get; set; }
        public DbSet<RoleWiseModel> roleWise { get; set; }
        public DbSet<RoleWiseOnlyEmployee> RoleWiseOnlyEmployees { get; set; }


    }
}








