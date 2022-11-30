using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IBalusterRepository
    {
        public IEnumerable<Baluster> GetAllBalusters();
        public void DeleteBaluster(Baluster b);
        public void UpdateBaluster(Baluster b);
        public void InsertBaluster(Baluster b);
    }
}
