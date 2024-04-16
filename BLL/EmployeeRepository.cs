﻿using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http.HttpResults;

namespace CRUDAPPLICATION.BLL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeDbContext employeeDbContext;
        public EmployeeRepository(EmployeeDbContext _employeeDbContext)
        {
            this.employeeDbContext = _employeeDbContext;
        }

        public void AllData(EmployeeProfile employeeProfile)
        {
            employeeDbContext.employeeProfiles.ToList().ForEach(p => p.Equals(employeeProfile));
            employeeDbContext.SaveChanges();
        }

        public EmployeeProfile delete(int id)
        {
            var employee = employeeDbContext.employeeProfiles.FirstOrDefault(a => a.id == id);

            if (employee != null)
            {
                employeeDbContext.employeeProfiles.Remove(employee);
                employeeDbContext.SaveChanges();
            }

            return employee;
        }

        public List<EmployeeProfile> GetAll()
        {
            var a = employeeDbContext.employeeProfiles.ToList();
            employeeDbContext.SaveChanges();
            return a;
        }

        public void insert(EmployeeProfile employeeProfile)
        {
            employeeDbContext.employeeProfiles.Add(employeeProfile);
            employeeDbContext.SaveChanges();



        }



        //public EmployeeRepository Search(int id)
        //{
        //employeeDbContext.employeeProfiles.Where(s => s.id == id).FirstOrDefault();
        //    employeeDbContext.SaveChanges(true);

        //}

        public void update(EmployeeProfile employeeProfile)
        {
            employeeDbContext.employeeProfiles.Update(employeeProfile);
            employeeDbContext.SaveChanges();
        }


    
     public     EmployeeProfile Search(int id)
        {
            var a = employeeDbContext.employeeProfiles.Where(s => s.id == id).FirstOrDefault();
            return a;
        }
    }
}