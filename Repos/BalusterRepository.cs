using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class BalusterRepository : IBalusterRepository
    {
        private readonly IDbConnection _conn;

        public BalusterRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void DeleteBaluster(Baluster b) 
        {
            _conn.Execute("DELETE FROM Baluster WHERE BalSetID = @id;", new { id = b.BalSetID });
        }

        public IEnumerable<Baluster> GetAllBalusters()
        {
            return _conn.Query<Baluster>("SELECT * FROM Baluster;");
        }

        public void InsertBaluster(Baluster b)
        {
            _conn.Execute("INSERT INTO Balusterquantity (Baluster, BalTypeID, HouseID, BalStyleID)" +
                "VALUES (@BalusterQuantity, @BalTypeID, @HouseID, @BallStyleID);",
                new { BalusterQuantity = b.BalusterQuantity, BalTypeID = b.BalTypeID, HouseID = b.HouseID, BalStyleID = b.BalStyleID });
        }

        public void UpdateBaluster(Baluster b)
        {
            _conn.Execute("UPDATE Baluster SET BalusterQuantity = @BalusterQuantity, BalTypeID= @BalTypeID, HouseID =@HouseID, BalStyleID=@BallStyleID;",
                new { BalusterQuantity = b.BalusterQuantity, BalTypeID = b.BalTypeID, HouseID = b.HouseID, BalStyleID = b.BalStyleID });
        }
    }
}
