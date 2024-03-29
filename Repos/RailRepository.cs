﻿using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class RailRepository : IRailRepository
    {
        private readonly IDbConnection _conn;

        public RailRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public void DeleteRail(Rail r)
        {
            _conn.Execute("DELETE FROM Rail WHERE RailID = @id;", new { id = r.RailID });
        }

        public IEnumerable<Rail> GetAllRails(int id)
        {
            return _conn.Query<Rail>("SELECT * FROM Rail WHERE HouseID = @id;", new { id = id });
        }


        public void InsertRail(Rail r)
        {
            _conn.Execute("INSERT INTO rail (RailLineNum, RailTypeID, RailStyleID, RailLength, ShoeLength, CapTypeID, CapLength, HouseID)" +
                "VALUES (@RailLineNum, @RailTypeID, @RailStyleID, @RailLength, @ShoeLength, @CapTypeID, @CapLength, @HouseID);",
                new
                {
                    RailLineNum = r.RailLineNum,
                    RailTypeID = r.RailTypeID,
                    RailStyleID = r.RailStyleID,
                    RailLength = r.RailLength,
                    ShoeLength = r.ShoeLength,
                    CapTypeID = r.CapTypeID,
                    CapLength = r.CapLength,
                    HouseID = r.HouseID
                    
                });
        }

        public void UpdateRail(Rail r)
        {
            _conn.Execute("UPDATE Rail SET RailLineNum = @RailLineNum, RailTypeID = @RailTypeID, RailStyleID = @RailStyleID, RailLength = @RailLength, ShoeLength = @ShoeLength, CapTypeID = @CapTypeID, CapLength = @CapLength, HouseID = @HouseID ;",
                 new
                 {
                     RailLineNum = r.RailLineNum,
                     RailTypeID = r.RailTypeID,
                     RailStyleID = r.RailStyleID,
                     RailLength = r.RailLength,
                     ShoeLength = r.ShoeLength,
                     CapTypeID = r.CapTypeID,
                     CapLength = r.CapLength,
                     HouseID = r.HouseID
                 });
        }
        public IEnumerable<RailStyle> GetRailStyle()
        {
            return _conn.Query<RailStyle>("SELECT RailStyleID, RailStyle as RailStyles FROM railstyle;");

        }
        public IEnumerable<RailType> GetRailType()
        {
            return _conn.Query<RailType>("SELECT RailTypeID, RailType as RailTypes FROM railtype;");

        }
        public IEnumerable<CapType> GetCapType()
        {
            return _conn.Query<CapType>("SELECT CapTypeID, CapType as CapTypes FROM captype;");

        }

        public OrderFull GetLotNum(int id)
        {
            var lotNum = _conn.QuerySingle<OrderFull>("SELECT * FROM orderfull WHERE HouseID = @id", new { id = id });
            return lotNum;
        }
    }
}
