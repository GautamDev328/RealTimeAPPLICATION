using CRUDAPPLICATION.Migrations;
using CRUDAPPLICATION.Model;
using System.Net;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IAdminLoginRepository {
      public   List<AdminLogin> GetAdminAll();
        public   void  AddLoginUser(AdminLogin admin);
public void Updateadmin(AdminLogin admin);
public void Deleteadmin(int  id);
public AdminLogin SearchByadmin(string userName);
bool ValidateAccount(string userName, string password);
}
}
