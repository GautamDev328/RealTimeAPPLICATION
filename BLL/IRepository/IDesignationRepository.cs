using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IDesignationRepository
    {
        public List<DesignationModel> GetALLDesignationData();
        public void CreateDesignation(DesignationModel designationModel);
        public void UpdateDesignationModel(DesignationModel designationModel);
        public void DeleteDesignationModel(int  id);
        public DesignationModel SearchById(int id);
        public DesignationModel DetailsDesignationModel(int  id );

    }
}
