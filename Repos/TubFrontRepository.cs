using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class TubFrontRepository : ITubFrontRepository
    {
                   private readonly IDbConnection _conn;

            public TubFrontRepository(IDbConnection conn)
            {
                _conn = conn;
            }

            public void DeleteTubFront(TubFront t)
            {
                _conn.Execute("DELETE FROM TubFront WHERE TubFrontID = @id;", new { id = t.TubFrontID });
            }

            public IEnumerable<TubFront> GetAllTubFronts()
            {
                return _conn.Query<TubFront>("SELECT * FROM TubFront;");
            }

        public void InsertTubFront(TubFront t)
        {
            _conn.Execute("INSERT INTO TubFront (TubFrontLength, TubFrontHeight, TubFrontQuantity, HouseID)" +
                "VALUES (@TubFrontLength, @TubFrontHeight, @TubFrontQuantity, @HouseID);",
                new { TubFrontLength = t.TubFrontLength, TubFrontHeight = t.TubFrontHeight, TubFrontQuantity = t.TubFrontQuantity, HouseID = t.HouseID });
            }
            public void UpdateTubFront(TubFront t)
            {
                _conn.Execute("UPDATE TubFront SET TubFrontLength = @TubFrontLength, TubeFrontHeight = @TubFrontHeight, TubFrontQuantity = @TubFrontQuantity, HouseID = @HouseID;",
                   new { TubFrontLength = t.TubFrontLength, TubFrontHeight = t.TubFrontHeight, TubFrontQuantity = t.TubFrontQuantity, HouseID = t.HouseID });
        }
        }
}
