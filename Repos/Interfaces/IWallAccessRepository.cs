using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IWallAccessRepository
    {
        public IEnumerable<WallAccess> GetAllWallAccesss();
        public void DeleteWallAccess(WallAccess w);
        public void UpdateWallAccess(WallAccess w);
        public void InsertWallAccess(WallAccess w);
    }
}
