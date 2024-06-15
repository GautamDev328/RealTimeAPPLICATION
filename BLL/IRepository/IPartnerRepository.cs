using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
	public interface IPartnerRepository
	{
		public List<PartnerLogin> GetPartnerLogin();
		public void CreatePartnerLogin(PartnerLogin login);	
		public void UpdatePartnerLogin(PartnerLogin login);
            public void DeletePartnerLogin(int id);
		public PartnerLogin SearchPartnerLogin(int id);	

	}
}
