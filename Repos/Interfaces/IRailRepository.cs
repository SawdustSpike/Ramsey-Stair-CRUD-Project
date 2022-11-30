using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IRailRepository
    {
        public IEnumerable<Rail> GetAllRails();
        public void DeleteRail(Rail r);
        public void UpdateRail(Rail r);
        public void InsertRail(Rail r);
    }
}
