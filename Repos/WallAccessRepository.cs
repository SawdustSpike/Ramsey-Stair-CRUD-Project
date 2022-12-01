using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class WallAccessRepository : IWallAccessRepository
    {       
            private readonly IDbConnection _conn;

            public WallAccessRepository(IDbConnection conn)
            {
                _conn = conn;
            }

            public void DeleteWallAccess(WallAccess w)
            {
                _conn.Execute("DELETE FROM WallAccess WHERE WallAccessID = @id;", new { id = w.WallAccessID });
            }

            public IEnumerable<WallAccess> GetAllWallAccesss()
            {
                return _conn.Query<WallAccess>("SELECT * FROM WallAccess;");
            }

            public void InsertWallAccess(WallAccess w)
            {
            _conn.Execute("INSERT INTO WallAccess (WallAccessNotes, WallAccessQuantity, WallAccessHeight, WallAccessWidth, HouseID) " +
                "VALUES (@WallAccessNotes, @WallAccessQauntity, @WallAccessHeight, @WallAccessWidth, @HouseID );",
                new { WallAccessNotes = w.WallAccessNotes, WallAccessQuantity = w.WallAccessQuantity, WallAccessHeight = w.WallAccessHeight, WallAccessWidth = w.WallAccessWidth, HouseID = w.HouseID });
            }

            public void UpdateWallAccess(WallAccess w)
            {
                _conn.Execute("UPDATE WallAccess SET WallAccessNotes = @WallAccessNotes, WallAccessQuantity = @WallAccessQauntity, WallAccessHeight = @WallAccessHeight, WallAccessWidth = @WallAccessWidth, HouseID = @HouseID ;",
                    new { WallAccessNotes = w.WallAccessNotes, WallAccessQuantity = w.WallAccessQuantity, WallAccessHeight = w.WallAccessHeight, WallAccessWidth = w.WallAccessWidth, HouseID = w.HouseID });
        }
        }
}
