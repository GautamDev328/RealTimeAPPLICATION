using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
	public class PartnerLoginRepositroy : IPartnerRepository
	{
		readonly EmployeeDbContext employeeDbContext;
        public PartnerLoginRepositroy(EmployeeDbContext _employeeDbContext)
        {
				this.employeeDbContext = _employeeDbContext;
        }
        public void CreatePartnerLogin(PartnerLogin login)
		{
			employeeDbContext.partners.Add(login);
			employeeDbContext.SaveChanges();
		}

		public void DeletePartnerLogin(int id)
		{
			var delete = employeeDbContext.partners.Where(s => s.Id == id).FirstOrDefault();
			  employeeDbContext.partners.Remove(delete);
			 employeeDbContext.SaveChanges();
		}

		public List<PartnerLogin> GetPartnerLogin()
		{
			var list = employeeDbContext.partners.ToList();
			return list;
		}

		//public void SearchPartnerLogin(int id)
		//{
		//	employeeDbContext.partners.Where(s=>s.Id==id).FirstOrDefault();
		//	employeeDbContext.SaveChanges();
			
		//}

		public void UpdatePartnerLogin(PartnerLogin login)
		{
		  employeeDbContext.partners.Update(login);
			employeeDbContext.SaveChanges();
		}

	public 	PartnerLogin SearchPartnerLogin(int id)
		{
			var a=employeeDbContext.partners.Where(s => s.Id == id).FirstOrDefault();
			return a;
		}
	}
}
