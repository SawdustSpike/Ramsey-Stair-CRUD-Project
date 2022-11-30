using Dapper;
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

        public IEnumerable<Rail> GetAllRails()
        {
            return _conn.Query<Rail>("SELECT * FROM Rail;");
        }

        public void InsertRail(Rail r)
        {
            _conn.Execute("INSERT INTO rail (RailLineNum, RailTypeID, RailStyleID, RailLength, CapTypeID, CapLength, HouseID, IronBal)" +
                "VALUES (@RailLineNum, @RailTypeID, @RailStyleID, @RailLength, @CapTypeID, @CapLength, @HouseID, @IronBal);",
                new
                {
                    RailLineNum = r.RailLineNum,
                    RailTypeID = r.RailTypeID,
                    RailStyleID = r.RailStyleID,
                    RailLength = r.RailLength,
                    CapTypeID = r.CapTypeID,
                    CapLength = r.CapLength,
                    HouseID = r.HouseID,
                    IronBal = r.IronBal
                });
        }

        public void UpdateRail(Rail r)
        {
            _conn.Execute("UPDATE Rail SET RailLineNum = @RailLineNum, RailTypeID = @RailTypeID, RailStyleID = @RailStyleID, RailLength = @RailLength, CapTypeID = @CapTypeID, CapLength = @CapLength, HouseID = @HouseID, IronBal = @IronBal;",
                 new
                 {
                     RailLineNum = r.RailLineNum,
                     RailTypeID = r.RailTypeID,
                     RailStyleID = r.RailStyleID,
                     RailLength = r.RailLength,
                     CapTypeID = r.CapTypeID,
                     CapLength = r.CapLength,
                     HouseID = r.HouseID,
                     IronBal = r.IronBal
                 });
        }
    }
}
