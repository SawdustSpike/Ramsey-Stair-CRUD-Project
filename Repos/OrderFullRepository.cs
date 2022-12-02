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
            throw new NotImplementedException();
           // _conn.Execute("DELETE FROM orderfull WHERE OrderID = @id;", new { id = o.OrderID });
        }

        public IEnumerable<OrderFull> GetAllOrderFulls()
        {
            return _conn.Query<OrderFull>("SELECT * FROM orderfull;");
        }

        public IEnumerable<Rail> GetAllRail()
        {
            throw new NotImplementedException();
          //  return _conn.Query<Rail>("SELECT * FROM Rail;");
        }

        public IEnumerable<BalusterType> GetBalusterTypes()
        {
            throw new NotImplementedException();
          //  return _conn.Query<BalusterType>("SELECT * FROM BalusterType;");
        }

        public IEnumerable<Builder> GetBuilders()
        {
            throw new NotImplementedException();
           // return _conn.Query<Builder>("SELCET * FROM builder;");
        }

        public IEnumerable<CapType> GetCapType()
        {
            throw new NotImplementedException();
         //   return _conn.Query<CapType>("SELECT CapTypeID, CapType as CapTypes FROM captype;");
        }

        public IEnumerable<LotNumber> GetLotNumbers()
        {
            throw new NotImplementedException();
          //  return _conn.Query<LotNumber>("SELECT * FROM house;");
        }

        public IEnumerable<Mantle> GetMantles()
        {
            throw new NotImplementedException();
          //  return _conn.Query<Mantle>("SELECT * FROM mantle;");
        }

        public IEnumerable<Niche> GetNiches()
        {
            throw new NotImplementedException();
          //  return _conn.Query<Niche>("SELECT * FROM Niche;");
        }

        public IEnumerable<RailStyle> GetRailStyle()
        {
            throw new NotImplementedException();
           // return _conn.Query<RailStyle>("SELECT RailStyleID, RailStyle as RailStyles FROM railstyle;");
        }

        public IEnumerable<RailType> GetRailType()
        {
            throw new NotImplementedException();
         //   return _conn.Query<RailType>("SELECT RailTypeID, RailType as RailTypes FROM railtype;");
        }

        public IEnumerable<TubFront> GetTubFronts()
        {
            throw new NotImplementedException();
          //  return _conn.Query<TubFront>("SELECT * FROM tubfront;");
        }

        public IEnumerable<WallAccess> GetWallAccesses()
        {
            throw new NotImplementedException();
          //  return _conn.Query<WallAccess>("SELECT * FROM wallaccess;");
        }

        public void InsertOrderFull(OrderFull o)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderFull(OrderFull o)
        {
            throw new NotImplementedException();
        }
    }
}
