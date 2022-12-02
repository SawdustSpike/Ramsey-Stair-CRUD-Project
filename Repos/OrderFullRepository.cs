using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class OrderFullRepository : IOrderFullRepository
    {
        private readonly IDbConnection _conn;

        public OrderFullRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public void DeleteOrderFull(OrderFull o)
        {
            
           _conn.Execute("DELETE FROM orderfull WHERE OrderID = @id;", new { id = o.OrderID });
        }

        public IEnumerable<OrderFull> GetAllOrderFull()
        {
            return _conn.Query<OrderFull>("SELECT * FROM orderfull;");
        }

        public IEnumerable<Rail> GetAllRail(int id)
        {
            
         return _conn.Query<Rail>("SELECT * FROM Rail WHERE HouseID = @id;", new { id = id});
        }

        public IEnumerable<BalusterType> GetBalusterTypes()
        {
           
          return _conn.Query<BalusterType>("SELECT * FROM BalusterType;");
        }

        public IEnumerable<Builder> GetBuilders()
        {
            
          return _conn.Query<Builder>("SELCET * FROM builder;");
        }

        public IEnumerable<CapType> GetCapType()
        {
          
        return _conn.Query<CapType>("SELECT CapTypeID, CapType as CapTypes FROM captype;");
        }

        public IEnumerable<LotNumber> GetLotNumbers()
        {
           
         return _conn.Query<LotNumber>("SELECT * FROM house;");
        }

        public IEnumerable<Mantle> GetMantles(int id)
        {
           
        return _conn.Query<Mantle>("SELECT * FROM mantle WHERE HouseID = @id;", new {id = id});
        }

        public IEnumerable<Niche> GetNiches(int id)
        {
           
         return _conn.Query<Niche>("SELECT * FROM Niche WHERE HouseID = @id;", new {id = id});
        }

        public IEnumerable<RailStyle> GetRailStyle()
        {
          
          return _conn.Query<RailStyle>("SELECT RailStyleID, RailStyle as RailStyles FROM railstyle;");
        }

        public IEnumerable<RailType> GetRailType()
        {
           
         return _conn.Query<RailType>("SELECT RailTypeID, RailType as RailTypes FROM railtype;");
        }

        public IEnumerable<TubFront> GetTubFronts(int id)
        {
            
            return _conn.Query<TubFront>("SELECT * FROM tubfront WHERE HouseID = @id;", new {id=id});
        }

        public IEnumerable<WallAccess> GetWallAccesses(int id)
        {

            return _conn.Query<WallAccess>("SELECT * FROM wallaccess WHERE HouseID = @id;", new {id = id});
        }

        public void InsertOrderFull(OrderFull o)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderFull(OrderFull o)
        {
            throw new NotImplementedException();
        }
        public void FullOrder(int id)
        {

        }
    }
}
