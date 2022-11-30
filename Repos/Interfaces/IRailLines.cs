using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IRailLines
    {
        public IEnumerable<RailLine> GetAllRail();
        public void DeleteRail(RailLine r);
        public void UpdateRail(RailLine r);
        public void InsertRail(RailLine r);
    }
}
