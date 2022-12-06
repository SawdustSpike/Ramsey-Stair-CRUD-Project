using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IRailRepository
    {
        public IEnumerable<Rail> GetAllRails(int id);
        public void DeleteRail(Rail r);
        public void UpdateRail(Rail r);
        public void InsertRail(Rail r);
        public IEnumerable<RailStyle> GetRailStyle();
        public IEnumerable<RailType> GetRailType();
        public IEnumerable<CapType> GetCapType();
        public OrderFull GetLotNum(int id);
       
    }
}
