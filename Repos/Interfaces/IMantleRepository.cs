using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IMantleRepository
    {
        public IEnumerable<Mantle> GetAllMantles(int id);
        public void DeleteMantle(Mantle m);
        public void UpdateMantle(Mantle m);
        public void InsertMantle(Mantle m);
        public OrderFull GetLotNum(int id);
    }
}
