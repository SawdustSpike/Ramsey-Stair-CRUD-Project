using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IOrderFullRepository
    {
        public IEnumerable<OrderFull> GetAllOrderFull();
        public void DeleteOrderFull(OrderFull o);
        public void UpdateOrderFull(OrderFull o);
        public void InsertOrderFull(OrderFull o);
        public IEnumerable<WallAccess> GetWallAccesses(int id);
        public IEnumerable<Niche> GetNiches(int id);
        public IEnumerable<Mantle> GetMantles(int id);
        public IEnumerable<TubFront> GetTubFronts(int id);
        public IEnumerable<Rail> GetAllRail(int id);
        public IEnumerable<RailStyle> GetRailStyle();
        public IEnumerable<RailType> GetRailType();
        public IEnumerable<CapType> GetCapType();
        public IEnumerable<LotNumber> GetLotNumbers();
        public IEnumerable<Builder> GetBuilders();
        public IEnumerable<BalusterType> GetBalusterTypes();
        public void FullOrder(int id);
    }
}
