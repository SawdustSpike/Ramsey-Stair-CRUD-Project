using Dapper;
using Org.BouncyCastle.Utilities;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class HouseRepository :IHouseRepository
    {
        private readonly IDbConnection _conn;

        public HouseRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void DeleteHouse(House h)
        {
            _conn.Execute("DELETE FROM House WHERE HouseID = @id;", new { id = h.HouseID });
        }

        public IEnumerable<House> GetAllHouses()
        {
            return _conn.Query<House>("SELECT * FROM House;");
        }

        public void InsertHouse(House h)
        {
            _conn.Execute("INSERT INTO House (LotNum)" +
                "VALUES (@LotNum);",
                new { lotNum = h.LotNum });

        }

        public void UpdateHouse(House h)
        {
            _conn.Execute("UPDATE Housedetail SET LotNum = @LotNum",              
                new { lotNum = h.LotNum });
        }
    }
}
