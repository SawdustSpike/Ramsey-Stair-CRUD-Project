using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IBalusters
    {
        public IEnumerable<Balusters> GetAllBalusters();
        public void DeleteBalusters(Balusters b);
        public void UpdateBalusters(Balusters b);
        public void InsertBalusters(Balusters b);
    }
}
