using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL
{
    public interface IEmployeeRepository
    {
        //public void AllData(EmployeeProfile employeeProfile); 
        public List<EmployeeProfile> GetAll();  
      public   void update(EmployeeProfile employeeProfile);
         public EmployeeProfile Search(int id);
        EmployeeProfile delete(int id);
        public void insert(EmployeeProfile employeeProfile);
    }
}
