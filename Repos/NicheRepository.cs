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

        public void DeleteNiche(Niche n)
        {
            _conn.Execute("DELETE FROM Niche WHERE nicheID = @id;", new { id = n.NicheID });
        }

        public IEnumerable<Niche> GetAllNiches()
        {
            return _conn.Query<Niche>("SELECT * FROM niche;");
        }

        public void InsertNiche(Niche n)
        {
            _conn.Execute("INSERT INTO niche (NicheHeight, NicheWidth, NicheQuantity, HouseID)" +
                "VALUES (@NicheHeight, @NicheWidth, @NicheQuantity, @HouseID);",
                new { NicheHeight = n.NicheHeight, NicheWidth = n.NicheWidth, NicheQuantity = n.NicheQuantity, HouseID = n.HouseID });
        }

        public void UpdateNiche(Niche n)
        {
            _conn.Execute("UPDATE niche SET NicheHeight = @NicheHeight, NicheWidth = @NicheWidth, NicheQuantity = @NicheQuantity, HouseID = @HouseID;",
                new { NicheHeight = n.NicheHeight, NicheWidth = n.NicheWidth, NicheQuantity = n.NicheQuantity, HouseID = n.HouseID });
        }
    }
}
