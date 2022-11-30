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

        public void DeleteNewels(Newels n)
        {
            _conn.Execute("DELETE FROM newels WHERE NewelSetID = @id;", new { id = n.NewelSetID });
        }

        public IEnumerable<Newels> GetAllNewels()
        {
            return _conn.Query<Newels>("SELECT * FROM NEWELS;");
        }

        public void InsertNewels(Newels n)
        {
            _conn.Execute("INSERT INTO newels" +
                "(Pitch, PitchSleeve, MiscPitch, Hippo, Flat, FlatSleeve, MiscFlat, MiscFlatSleeve)" +
                "VALUES (@Pitch, @PitchSleeve, @MiscPitch, @Hippo, @Flat, @FlatSleeve, @MiscFlat, @MiscFlatSleeve);",
                new { Pitch = n.Pitch, PitchSleeve = n.PitchSleeve, MiscPitch = n.MiscPitch, Hippo = n.Hippo, Flat = n.Flat,
                FlatSleeve = n.FlatSleeve, MiscFlat = n.MiscFlat, MiscFlatSleeve = n.MiscFlatSleeve});
        }

        public void UpdateNewels(Newels n)
        {
            _conn.Execute("UPDATE newels" +
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
