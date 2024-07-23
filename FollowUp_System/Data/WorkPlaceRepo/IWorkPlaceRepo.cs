using FollowUp_System.Model.WorkPlaceModel;

namespace FollowUp_System.Data.WorkPlaceRepo
{
    public interface IWorkPlaceRepo
    {
        Task<IEnumerable<WorkPlaceRead>> GetAll();
        Task<WorkPlaceRead> GetById(long id);
        
    }
}
