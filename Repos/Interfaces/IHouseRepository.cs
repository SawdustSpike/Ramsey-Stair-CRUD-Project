using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IHouse
    {
        public IEnumerable<House> GetAllHouses();
        public void DeleteHouses(House h);
        public void UpdateHouses(House h);
        public void InsertHouses(House h);
    }
}
