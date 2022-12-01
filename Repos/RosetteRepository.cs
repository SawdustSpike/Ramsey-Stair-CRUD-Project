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
            _conn.Execute("INSERT INTO Rosette HouseID, PitchRose, FlatRose )" +
                "VALUES ( @HouseID, @PitchRose, @FlatRose);",
                new { HouseID = r.HouseID, PitchRose = r.PitchRose, FlatRose = r.FlatRose });
        }
        public void UpdateRosette(Rosette r)
        {
            _conn.Execute("UPDATE Rosette SET HouseID = @HouseID, PitchRose = @PitchRose, FlatRose = @FlatRose;",
                new { HouseID = r.HouseID, PitchRose = r.PitchRose, FlatRose = r.FlatRose });
        }
    }
}
