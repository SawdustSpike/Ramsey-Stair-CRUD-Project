using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface ITubFrontRepository
    {
        public IEnumerable<TubFront> GetAllTubFronts();
        public void DeleteTubFront(TubFront t);
        public void UpdateTubFront(TubFront t);
        public void InsertTubFront(TubFront t);
    }
}
