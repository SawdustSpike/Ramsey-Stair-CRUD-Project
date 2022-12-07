using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class NicheRepository : INicheRepository
    {
        private readonly IDbConnection _conn;

        public NicheRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void DeleteNiche(Niche m)
        {
            _conn.Execute("DELETE FROM Niche WHERE NicheID = @id;", new { id = m.NicheID });
        }

        public IEnumerable<Niche> GetAllNiches(int id)
        {
            return _conn.Query<Niche>("SELECT * FROM Niche WHERE HouseID = @id;", new { id = id });
        }

        public void InsertNiche(Niche m)
        {
            _conn.Execute("INSERT INTO Niche (NicheHeight, NicheWidth, NicheQuantity, HouseID)" +
                "VALUES (@NicheHeight, @NicheWidth, @NicheQuantity, @HouseID);",
                new { NicheHeight = m.NicheHeight, NicheWidth = m.NicheWidth, NicheQuantity = m.NicheQuantity, HouseID = m.HouseID,  });

        }

        public void UpdateNiche(Niche m)
        {
            _conn.Execute("UPDATE Niches SET NicheHeight = @NicheHeight, NicheWidth = @NicheWidth, NicheQuantity = @NicheQuantity, HouseID = @HouseID, ;",
                new { NicheHeight = m.NicheHeight, NicheWidth = m.NicheWidth, NicheQuantity = m.NicheQuantity, HouseID = m.HouseID, });
        }
        public OrderFull GetLotNum(int id)
        {
            var lotNum = _conn.QuerySingle<OrderFull>("SELECT * FROM orderfull WHERE HouseID = @id", new { id = id });
            return lotNum;
        }
    }
}
