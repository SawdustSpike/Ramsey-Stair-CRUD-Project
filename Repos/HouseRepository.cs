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
            _conn.Execute("INSERT INTO Housedetail (LotNum, Address, Notes, Model, SubDiv, BuilderID, HardwareColor, WI)" +
                "VALUES (@LotNum, @Address, @Notes, @Model, @SubDiv, @BuilderID, @HardwareColor, @WI);",
                new { Address = h.Address, Notes = h.Notes, Model = h.Model, SubDiv = h.SubDiv, BuilderID = h.BuilderID, HardwareID = h.HardwareColor, WI = h.WI });

        }

        public void UpdateHouse(House h)
        {
            _conn.Execute("UPDATE Housedetail SET LotNum = @LotNum, Address = @Address, Notes = @Notes, Model = @Model, SubDiv = @SubDiv, BuilderID = @BuilderID, HardwareID = @HardwareColor, WI = @WI;",              
                new { Address = h.Address, Notes = h.Notes, Model = h.Model, SubDiv = h.SubDiv, BuilderID = h.BuilderID, HardwareID = h.HardwareColor, WI = h.WI });
        }
    }
}
