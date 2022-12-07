using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class MantleRepository : IMantleRepository
    {
       
            private readonly IDbConnection _conn;

            public MantleRepository(IDbConnection conn)
            {
                _conn = conn;
            }

            public void DeleteMantle(Mantle m)
            {
                _conn.Execute("DELETE FROM Mantle WHERE MantleID = @id;", new { id = m.MantleID });
            }

            public IEnumerable<Mantle> GetAllMantles(int id)
            {
                return _conn.Query<Mantle>("SELECT * FROM Mantle WHERE HouseID = @id;", new {id = id});
            }

            public void InsertMantle(Mantle m)
            {
                _conn.Execute("INSERT INTO Mantle (MantleType, MantleNotes, HouseID, MantleQuantity)" +
                    "VALUES (@MAntleType, @MantleNotes, @HouseID, @MantleQuantity);",
                    new { MantleType = m.MantleType, MantleNotes =m.MantleNotes, HouseID =m.HouseID, MantleQuantity=m.MantleQuantity });

            }

            public void UpdateMantle(Mantle m)
            {
                _conn.Execute("UPDATE Mantles SET MantleType = @MAntleType, MantleNotes = @MantleNotes, HouseID = @HouseID, MantleQuantity = @MantleQuantity;",
                    new { MantleType = m.MantleType, MantleNotes = m.MantleNotes, HouseID = m.HouseID, MantleQuantity = m.MantleQuantity });
        }
        public OrderFull GetLotNum(int id)
        {
            var lotNum = _conn.QuerySingle<OrderFull>("SELECT * FROM orderfull WHERE HouseID = @id", new { id = id });
            return lotNum;
        }
    }
 }

