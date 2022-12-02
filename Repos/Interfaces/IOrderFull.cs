using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IOrderFullRepository
    {
        public IEnumerable<OrderFull> GetAllOrderFulls();
        public void DeleteOrderFull(OrderFull o);
        public void UpdateOrderFull(OrderFull o);
        public void InsertOrderFull(OrderFull o);
        public IEnumerable<WallAccess> GetWallAccesses();
        public IEnumerable<Niche> GetNiches();
        public IEnumerable<Mantle> GetMantles();
        public IEnumerable<TubFront> GetTubFronts();
        public IEnumerable<Rail> GetAllRail();
        public IEnumerable<RailStyle> GetRailStyle();
        public IEnumerable<RailType> GetRailType();
        public IEnumerable<CapType> GetCapType();
        public IEnumerable<LotNumber> GetLotNumbers();
        public IEnumerable<Builder> GetBuilders();
        public IEnumerable<BalusterType> GetBalusterTypes();
    }
}
