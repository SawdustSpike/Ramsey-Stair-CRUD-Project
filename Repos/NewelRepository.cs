using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class NewelRepository : INewelRepository
    {
        private readonly IDbConnection _conn;

        public NewelRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void DeleteNewel(Newel n)
        {
            _conn.Execute("DELETE FROM newel WHERE NewelSetID = @id;", new { id = n.NewelSetID });
        }

        public IEnumerable<Newel> GetAllNewels()
        {

            return _conn.Query<Newel>("SELECT * FROM newel;");
        }

        public void InsertNewel(Newel n)
        {
            _conn.Execute("INSERT INTO newel" +
                "(Pitch, PitchSleeve, MiscPitch, Hippo, Flat, FlatSleeve, MiscFlat, MiscFlatSleeve)" +
                "VALUES (@Pitch, @PitchSleeve, @MiscPitch, @Hippo, @Flat, @FlatSleeve, @MiscFlat, @MiscFlatSleeve);",
                new { Pitch = n.Pitch, PitchSleeve = n.PitchSleeve, MiscPitch = n.MiscPitch, Hippo = n.Hippo, Flat = n.Flat,
                FlatSleeve = n.FlatSleeve, MiscFlat = n.MiscFlat, MiscFlatSleeve = n.MiscFlatSleeve});
        }

        public void UpdateNewel(Newel n)
        {
            _conn.Execute("UPDATE newel" +
               "SET Pitch =@Pitch, PitchSleeve = @PitchSleeve, MiscPitch = @MiscPitch, Hippo = @Hippo, Flat = @Flat, FlatSleeve = @FlatSleeve, MiscFlat= @MiscFlat, MiscFlatSleeve= @MiscFlatSleeve;" +
               new
               {
                   Pitch = n.Pitch,
                   PitchSleeve = n.PitchSleeve,
                   MiscPitch = n.MiscPitch,
                   Hippo = n.Hippo,
                   Flat = n.Flat,
                   FlatSleeve = n.FlatSleeve,
                   MiscFlat = n.MiscFlat,
                   MiscFlatSleeve = n.MiscFlatSleeve
               });
        }
    }
}
