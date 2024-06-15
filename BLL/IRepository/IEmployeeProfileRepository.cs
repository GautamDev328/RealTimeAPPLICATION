using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IEmployeeProfileRepository
    {
        public List<EmployeeProfile> GetAll();
        public void updateEmployeeProfile(EmployeeProfile employeeProfile);
        public EmployeeProfile Search(int id);
        public EmployeeProfile DetailsEmployeeProfile(int  id);
       public  void deleteEmployeeProfile(int id);
        public void insert(EmployeeProfile employeeProfile);
    }
}
