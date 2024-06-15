using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IDesignationRepository
    {
        public List<DesignationModel> GetALLDesignationData();
        public void CreateDesignation(DesignationModel designationModel);
        public void UpdateDesignationModel(DesignationModel designationModel);
        public void DeleteDesignationModel(DesignationModel designationModel);
        public void SearchById(int id);
        public void DetailsDesignationModel(DesignationModel designationModel);

    }
}
