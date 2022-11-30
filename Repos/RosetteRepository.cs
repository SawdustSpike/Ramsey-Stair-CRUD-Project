using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class RosetteRepository:IRosetteRepository
    {
        private readonly IDbConnection _conn;

        public RosetteRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void DeleteRosette(Rosette r)
        {
            _conn.Execute("DELETE FROM Rosette WHERE RoseID = @id;", new { id = r.RoseID });
        }

        public IEnumerable<Rosette> GetAllRosettes()
        {
            return _conn.Query<Rosette>("SELECT * FROM Rosette;");
        }

        public void InsertRosette(Rosette r)
        {
            _conn.Execute("INSERT INTO Rosette (RosetteQuantity, HouseID, RoseStyleID, RoseTypeID)" +
                "VALUES (@RosetteQuantity, @HouseID, @RoseStyleID, @RoseTypeID);",
                new { RosetteQuantity = r.RosetteQuantity, HouseID = r.HouseID, RoseStyleID = r.RoseStyleID, RoseTypeID = r.RoseTypeID });
        }
        public void UpdateRosette(Rosette r)
        {
            _conn.Execute("UPDATE Rosette SET RosetteQuantity = @RosetteQuantity, HouseID = @HouseID, RoseStyleID = @RoseStyleID, RoseTypeID = @RoseTypeID;",
                new { RosetteQuantity = r.RosetteQuantity, HouseID = r.HouseID, RoseStyleID = r.RoseStyleID, RoseTypeID = r.RoseTypeID });
        }
    }
}
