using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IHouseRepository
    {
        public IEnumerable<House> GetAllHouses();
        public void DeleteHouse(House h);
        public void UpdateHouse(House h);
        public void InsertHouse(House h);
    }
}
