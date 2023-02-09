using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IOrderFullRepository
    {
        public IEnumerable<OrderFull> GetAllOrderFull();
        public OrderFull GetOrderFull(int id);
        public void DeleteOrderFull(OrderFull order);
        public void UpdateLotNum(OrderFull o);   
        public void UpdateMillWork(OrderFull o);
        public IEnumerable<WallAccess> GetWallAccesses(int id);
        public IEnumerable<Niche> GetNiches(int id);
        public IEnumerable<Mantle> GetMantles(int id);
        public IEnumerable<TubFront> GetTubFronts(int id);
        public IEnumerable<Rail> GetAllRail(int id);
        public IEnumerable<RailStyle> GetRailStyle();
        public IEnumerable<RailType> GetRailType();
        public IEnumerable<CapType> GetCapType();   
        public IEnumerable<Builder> GetBuilders();
        public IEnumerable<BalusterStyle> GetBalusterStyle();
        public OrderFull FullOrder(int id);
        public void InsertHouse(OrderFull o);
        public string PickBuilder(int id);
        public string PickBaluster(int id);
        public Dictionary<int, string> PickRailType();
        public Dictionary<int, string> PickRailStyle();
        public Dictionary<int, string> PickCapType();
        public int? GetHouseID(string lotNum);
        public void UpdateHouseDetails(OrderFull o);
      
    }
}
