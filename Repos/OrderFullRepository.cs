﻿using Dapper;
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
        public void DeleteOrderFull(int id)
        {
            
           _conn.Execute("DELETE FROM orderfull WHERE HouseID = @id;", new { id = id });
         
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
            
          return _conn.Query<Builder>("SELECT * FROM builder;");
        }

        public IEnumerable<CapType> GetCapType()
        {
          
        return _conn.Query<CapType>("SELECT CapTypeID, CapType as CapTypes FROM captype;");
        }

        public string GetLotNumber(int id)
        {
           
         return _conn.QuerySingle<LotNumber>("SELECT * FROM house WHERE HouseID = @id;", new {id=id}).LotNum;
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
            
            return _conn.Query<TubFront>("SELECT * FROM tubfront WHERE HouseID = @id;", new {id = id});
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
        public OrderFull FullOrder(int id) 
        {
            return _conn.QuerySingle<OrderFull>("SELECT * FROM orderfull WHERE HouseID = @id;", new { id = id });
        }

        public IEnumerable<LotNumber> GetLotNumbers()
        {
            return _conn.Query<LotNumber>("SELECT * FROM house;");
        }
    }
}
